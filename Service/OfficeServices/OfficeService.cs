using Microsoft.EntityFrameworkCore;
using WebApplicationETS.Data;
using WebApplicationETS.Factories;
using WebApplicationETS.Model.Compliances.Office;
using WebApplicationETS.Model.Dtos;
using WebApplicationETS.Model.otherModel;

namespace WebApplicationETS.Service.OfficeServices
{
    public class OfficeService: IOfficeService
    {

        private readonly DataContext _context;
        private readonly IOfficeFactory _officeFactory;

        public OfficeService(DataContext context, IOfficeFactory officeFactory)
        {
            _context = context;
            _officeFactory = officeFactory;
        }

        public async Task<ApiResponse<Office>> AddOfficeAsync(OfficeDto dto)
        {
            if (dto == null)
                return new ApiResponse<Office>(false, null, "Invalid office data");

            bool exists = await _context.Office
                .AnyAsync(o => o.locCode == dto.locCode);

            if (exists)
                return new ApiResponse<Office>(false, null, "Office with the same locCode already exists");

            var result = _officeFactory.Create(dto);

            if (!result.success)
                return new ApiResponse<Office>(false, null, result.errorMessage);

            _context.Office.Add(result.office);
            await _context.SaveChangesAsync();

            return new ApiResponse<Office>(true, result.office, "Office added successfully");
        }


        public async Task<ApiResponse<List<Office>>> GetAllOfficesAsync()
        {
            var offices = await _context.Office.ToListAsync();
            return new ApiResponse<List<Office>>(true, offices, "Offices retrieved successfully");
        }


        public async Task<ApiResponse<Office>> GetOfficeByIdAsync(int officeId)
        {
            var office = await _context.Office.FindAsync(officeId);
            if (office == null)
                return new ApiResponse<Office>(false, null, "Office not found");
            return new ApiResponse<Office>(true, office, "Office retrieved successfully");
        }

        public async Task<ApiResponse<Office>> UpdateOfficeAsync(int officeId, OfficeDto dto)
        {
            try
            {
                if (dto == null)
                    return new ApiResponse<Office>(false, null, "Invalid office data");

                // 🔹 Validation rules
                if (dto.locCode <= 0)
                    return new ApiResponse<Office>(false, null, "Location code must be greater than zero");

                if (string.IsNullOrWhiteSpace(dto.locName))
                    return new ApiResponse<Office>(false, null, "Location name is required");

                if (dto.lat < -90 || dto.lat > 90)
                    return new ApiResponse<Office>(false, null, "Latitude must be between -90 and 90");

                if (dto.lng < -180 || dto.lng > 180)
                    return new ApiResponse<Office>(false, null, "Longitude must be between -180 and 180");

                if (string.IsNullOrWhiteSpace(dto.address))
                    return new ApiResponse<Office>(false, null, "Address is required");

                if (string.IsNullOrWhiteSpace(dto.city))
                    return new ApiResponse<Office>(false, null, "City is required");

                if (string.IsNullOrWhiteSpace(dto.state))
                    return new ApiResponse<Office>(false, null, "State is required");

                if (string.IsNullOrWhiteSpace(dto.helpDeskContactNumber))
                    return new ApiResponse<Office>(false, null, "Help Desk Contact Number is required");

                if (string.IsNullOrWhiteSpace(dto.sosContactNumber))
                    return new ApiResponse<Office>(false, null, "SOS Contact Number is required");

                if (string.IsNullOrWhiteSpace(dto.driverAppIVRNumber))
                    return new ApiResponse<Office>(false, null, "Driver App IVR Number is required");

                if (string.IsNullOrWhiteSpace(dto.userAppIVRNumber))
                    return new ApiResponse<Office>(false, null, "User App IVR Number is required");

                if (dto.disableTransportCutoffDays < 0)
                    return new ApiResponse<Office>(false, null, "Disable Transport Cutoff Days cannot be negative");

                // 🔹 Find existing office
                var existingOffice = await _context.Office
                    .FirstOrDefaultAsync(o => o.officeId == officeId);
                if (existingOffice == null)
                    return new ApiResponse<Office>(false, null, "Office not found");

                // 🔹 Check uniqueness of locCode (ignore current office)
                bool locCodeExists = await _context.Office
                    .AnyAsync(o => o.locCode == dto.locCode && o.officeId != officeId);
                if (locCodeExists)
                    return new ApiResponse<Office>(false, null, "Office with the same locCode already exists");

                // 🔹 Update fields
                existingOffice.locCode = dto.locCode;
                existingOffice.locName = dto.locName;
                existingOffice.address = dto.address;
                existingOffice.city = dto.city;
                existingOffice.state = dto.state;
                existingOffice.lat = dto.lat;
                existingOffice.lng = dto.lng;
                existingOffice.dispName = dto.dispName;
                existingOffice.shortName = dto.shortName;
                existingOffice.locGroup = dto.locGroup;
                existingOffice.cityZone = dto.cityZone;
                existingOffice.helpDeskContactNumber = dto.helpDeskContactNumber;
                existingOffice.sosContactNumber = dto.sosContactNumber;
                existingOffice.driverAppIVRNumber = dto.driverAppIVRNumber;
                existingOffice.userAppIVRNumber = dto.userAppIVRNumber;
                existingOffice.active = dto.active;
                existingOffice.modBy = dto.modBy;
                existingOffice.modOn = DateTime.UtcNow;
                existingOffice.isAutoPenalty = dto.isAutoPenalty;
                existingOffice.isPanicSound = dto.isPanicSound;
                existingOffice.disableTransportCutoffDays = dto.disableTransportCutoffDays;
                existingOffice.disableTransportJob = dto.disableTransportJob;

                await _context.SaveChangesAsync();
                return new ApiResponse<Office>(true, existingOffice, "Office updated successfully");
            }
            catch (Exception ex)
            {
                // Log the exception as needed
                return new ApiResponse<Office>(false, null, "An error occurred while updating the office: " + ex.Message);
            }
        }



    }
}
