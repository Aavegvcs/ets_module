using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.otherModel;

namespace WebApplicationETS.Service.CompliancesServices.VehicleServices.VehicleStatusService
{
    public interface IVehicleStatusService
    {
        Task<ApiResponse<LkpVehicleStatus>> AddVehicleStatusAsync(LkpVehicleStatus vehicleStatus);
        Task<ApiResponse<LkpVehicleStatus>> getVehicleStatusByIdAsync(int vehicleStatus);
        Task<ApiResponse<List<LkpVehicleStatus>>> getVehicleStatusAsync();
        Task<ApiResponse<LkpVehicleStatus>> updateVehicleStatusByIdAsync(int vehicleStatus, LkpVehicleStatus updatedVehicleStatus);
        Task<ApiResponse<bool>> deleteVehicleStatusByIdAsync(int vehicleStatus);
    }
}
