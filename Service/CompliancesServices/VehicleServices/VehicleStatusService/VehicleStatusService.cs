using Microsoft.EntityFrameworkCore;
using WebApplicationETS.Data;
using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.otherModel;

namespace WebApplicationETS.Service.CompliancesServices.VehicleServices.VehicleStatusService
{
    public class VehicleStatusService: IVehicleStatusService
    {

        private readonly DataContext _context;

        public VehicleStatusService(DataContext context)
        {
            _context = context;
        }
        public async Task<ApiResponse<LkpVehicleStatus>> AddVehicleStatusAsync(LkpVehicleStatus vehicleStatus)
        {
                if(vehicleStatus == null)
                {
                 return new ApiResponse<LkpVehicleStatus>(false, null, "Invalid vehicle status data");
                }
                _context.LkpVehicleStatuses.Add(vehicleStatus);
                await _context.SaveChangesAsync();
                return new ApiResponse<LkpVehicleStatus>(true, vehicleStatus, "Vehicle status added successfully");
        }

        public async Task<ApiResponse<LkpVehicleStatus>> getVehicleStatusByIdAsync(int vehicleStatusCode)
        {
            if(vehicleStatusCode == null)
            {
                return new ApiResponse<LkpVehicleStatus>(false, null, "Invalid vehicle status id");
            }
            var vehicleStatus = await _context.LkpVehicleStatuses.FindAsync(vehicleStatusCode);
            if(vehicleStatus == null)
            {
                return new ApiResponse<LkpVehicleStatus>(false, null, "Vehicle status not found");
            }
            return new ApiResponse<LkpVehicleStatus>(true, vehicleStatus, "Vehicle status fetched successfully");
        }


        public async Task<ApiResponse<List<LkpVehicleStatus>>> getVehicleStatusAsync()
        {
            var vehicleStatuses = await _context.LkpVehicleStatuses.ToListAsync();
            if(vehicleStatuses == null || vehicleStatuses.Count == 0)
            {
                return new ApiResponse<List<LkpVehicleStatus>>(false, null, "No vehicle status found");
            }
            return new ApiResponse<List<LkpVehicleStatus>>(true, vehicleStatuses, "Vehicle statuses fetched successfully");
        }

        public async Task<ApiResponse<LkpVehicleStatus>> updateVehicleStatusByIdAsync(int vehicleStatusCode, LkpVehicleStatus updatedVehicleStatus)
        {
            if(vehicleStatusCode == null || updatedVehicleStatus == null)
            {
                return new ApiResponse<LkpVehicleStatus>(false, null, "Invalid vehicle status data");
            }
            var existingVehicleStatus = await _context.LkpVehicleStatuses.FindAsync(vehicleStatusCode);
            if(existingVehicleStatus == null)
            {
                return new ApiResponse<LkpVehicleStatus>(false, null, "Vehicle status not found");
            }
            existingVehicleStatus.vehicleStatusName = updatedVehicleStatus.vehicleStatusName;
            existingVehicleStatus.active = updatedVehicleStatus.active;
            _context.LkpVehicleStatuses.Update(existingVehicleStatus);
            await _context.SaveChangesAsync();
            return new ApiResponse<LkpVehicleStatus>(true, existingVehicleStatus, "Vehicle status updated successfully");
        }

        public async Task<ApiResponse<bool>> deleteVehicleStatusByIdAsync(int vehicleStatusCode)
        {
            if (vehicleStatusCode == null)
            {
                return new ApiResponse<bool>(false, false, "Invalid vehicle status id");
            }
            var existingVehicleStatus = await _context.LkpVehicleStatuses.FindAsync(vehicleStatusCode);
            if (existingVehicleStatus == null)
            {
                return new ApiResponse<bool>(false, false, "Vehicle status not found");
            }
            _context.LkpVehicleStatuses.Remove(existingVehicleStatus);
            await _context.SaveChangesAsync();
            return new ApiResponse<bool>(true, true, "Vehicle status deleted successfully");
        }



    }
}
