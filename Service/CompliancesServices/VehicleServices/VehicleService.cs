using Microsoft.EntityFrameworkCore;
using WebApplicationETS.Data;
//using WebApplicationETS.Factories;
using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.DTOs;
using WebApplicationETS.Model.otherModel;


namespace WebApplicationETS.Service.CompliancesServices.VehicleServices
{
    public class VehicleService: IVehicleService
    {
        private readonly DataContext _context;
        private readonly IVehicleFactory _vehicleFactory;
        public VehicleService(DataContext context ,IVehicleFactory vehicleFactory)
        {
            _context = context;
            _vehicleFactory = vehicleFactory;

        }
        public async Task<ApiResponse<Vehicle>> AddVehicleAsync(VehicleDto dto)
        {
            if (dto == null)
                return new ApiResponse<Vehicle>(false, null, "Invalid vehicle data");

            bool exists = await _context.Vehicles
           .AnyAsync(v => v.vehicleRegistrationNo == dto.vehicleRegistrationNo);

            if (exists)
                return new ApiResponse<Vehicle>(false, null, "Vehicle registration number already exists");

            var result = _vehicleFactory.Create(dto);
            if (!result.Success)
                return new ApiResponse<Vehicle>(false, null, result.ErrorMessage);

            _context.Vehicles.Add(result.Vehicle!);
            await _context.SaveChangesAsync();

            return new ApiResponse<Vehicle>(true, result.Vehicle, "Vehicle added successfully");
        }

        public async Task<ApiResponse<Vehicle>> UpdateVehicleAsync(int vehicleId, VehicleDto dto)
        {
            try
            {
                if (dto == null)
                    return new ApiResponse<Vehicle>(false, null, "Invalid vehicle data");

                var existingVehicle = await _context.Vehicles
                    .FirstOrDefaultAsync(v => v.vehicleId == vehicleId);

                if (existingVehicle == null)
                    return new ApiResponse<Vehicle>(false, null, "Vehicle not found");

                // ✅ Check uniqueness of registration number (ignore same vehicle)
                bool regExists = await _context.Vehicles
                    .AnyAsync(v => v.vehicleRegistrationNo == dto.vehicleRegistrationNo && v.vehicleId != vehicleId);

                if (regExists)
                    return new ApiResponse<Vehicle>(false, null, "Vehicle registration number already exists");

                // ✅ Run factory validations
                var result = _vehicleFactory.Create(dto);
                if (!result.Success)
                    return new ApiResponse<Vehicle>(false, null, result.ErrorMessage);

                var validatedVehicle = result.Vehicle!;

                // ✅ Update only allowed fields (copy properties)
                existingVehicle.vehicleRegistrationNo = validatedVehicle.vehicleRegistrationNo;
                existingVehicle.vehicleTypeCode = validatedVehicle.vehicleTypeCode;
                existingVehicle.transporterId = validatedVehicle.transporterId;
                existingVehicle.bpId = validatedVehicle.bpId;

                existingVehicle.trackeeId = validatedVehicle.trackeeId;
                existingVehicle.trackeeName = validatedVehicle.trackeeName;

                existingVehicle.vehicleStatus = validatedVehicle.vehicleStatus;
                existingVehicle.locCode = validatedVehicle.locCode;
                existingVehicle.vehicleRegistrationDate = validatedVehicle.vehicleRegistrationDate;
                existingVehicle.vehicleInductionDate = validatedVehicle.vehicleInductionDate;
                existingVehicle.registrationExpDate = validatedVehicle.registrationExpDate;
                existingVehicle.firstAidKidDate = validatedVehicle.firstAidKidDate;
                existingVehicle.fireExtinguisherDate = validatedVehicle.fireExtinguisherDate;

                existingVehicle.driverId = validatedVehicle.driverId;
                existingVehicle.Make = validatedVehicle.Make;
                existingVehicle.model = validatedVehicle.model;
                existingVehicle.chassisNo = validatedVehicle.chassisNo;

                existingVehicle.permitExpiryDate = validatedVehicle.permitExpiryDate;
                existingVehicle.insuranceExpiryDate = validatedVehicle.insuranceExpiryDate;
                existingVehicle.fitnessExpiryDate = validatedVehicle.fitnessExpiryDate;
                existingVehicle.roadTaxValidityExpiry = validatedVehicle.roadTaxValidityExpiry;
                existingVehicle.pucExpiryDate = validatedVehicle.pucExpiryDate;

                existingVehicle.kmsRunBeforeOnboarding = validatedVehicle.kmsRunBeforeOnboarding;
                existingVehicle.insuranceAgencyName = validatedVehicle.insuranceAgencyName;
                existingVehicle.ownerName = validatedVehicle.ownerName;
                existingVehicle.ccpermitDate = validatedVehicle.ccpermitDate;
                existingVehicle.ownerAddress = validatedVehicle.ownerAddress;
                existingVehicle.ownerType = validatedVehicle.ownerType;

                existingVehicle.validTokenTaxDate = validatedVehicle.validTokenTaxDate;
                existingVehicle.passengerTaxDate = validatedVehicle.passengerTaxDate;

                existingVehicle.isGpsInstalled = validatedVehicle.isGpsInstalled;
                existingVehicle.gpsInstallationDate = validatedVehicle.gpsInstallationDate;
                existingVehicle.gpsProviderCode = validatedVehicle.gpsProviderCode;

                existingVehicle.fuelTypeCode = validatedVehicle.fuelTypeCode;
                existingVehicle.cngEndorsementInRc = validatedVehicle.cngEndorsementInRc;
                existingVehicle.currentStatus = validatedVehicle.currentStatus;
                existingVehicle.mandatorySignage = validatedVehicle.mandatorySignage;

                existingVehicle.engineCapacityCc = validatedVehicle.engineCapacityCc;

                existingVehicle.modBy = validatedVehicle.modBy;
                existingVehicle.modOn = DateTime.UtcNow; // always update modification time
                existingVehicle.makeYear = validatedVehicle.makeYear;

                existingVehicle.remarks = validatedVehicle.remarks;

                await _context.SaveChangesAsync();

                return new ApiResponse<Vehicle>(true, existingVehicle, "Vehicle updated successfully");
            }
            catch (Exception ex)
            {
                return new ApiResponse<Vehicle>(false, null, $"An error occurred: {ex.Message}");
            }
        }

        public async Task<ApiResponse<List<Vehicle>>> GetAllVehicleAsync()
        {
            var vehicles = await _context.Vehicles.ToListAsync();
            return new ApiResponse<List<Vehicle>>(true, vehicles,
                vehicles.Any() ? "Vehicles retrieved successfully" : "No vehicles found");
        }

        public async Task<ApiResponse<Vehicle>> GetVehicleByIdAsync(int vehicleId)
        {
            var vehicle = await _context.Vehicles
                .FirstOrDefaultAsync(v => v.vehicleId == vehicleId);

            if (vehicle == null)
                return new ApiResponse<Vehicle>(false, null, "Vehicle not found");

            return new ApiResponse<Vehicle>(true, vehicle, "Vehicle retrieved successfully");
        }


    }
}
