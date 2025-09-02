using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.otherModel;

namespace WebApplicationETS.Service.CompliancesServices.VehicleServices.VehicleModelService
{
    public interface IVehicleModelService
    {

        Task<ApiResponse<lkpVehicleModel>> AddVehicleModelAsync(lkpVehicleModel vehicleModel);
        Task<ApiResponse<lkpVehicleModel>> getVehicleModelByidAsync(int MODELID);
        Task<ApiResponse<List<lkpVehicleModel>>> getVehicleModelAsync();
        Task<ApiResponse<lkpVehicleModel>> updateVehicleModelByidAsync(int MODELID, lkpVehicleModel updatedVehicleModel);
        Task<ApiResponse<lkpVehicleModel>> deleteVehicleModelByid(int MODELID);
    }
}
