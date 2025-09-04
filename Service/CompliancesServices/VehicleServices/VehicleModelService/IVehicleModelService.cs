using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.otherModel;

namespace WebApplicationETS.Service.CompliancesServices.VehicleServices.VehicleModelService
{
    public interface IVehicleModelService
    {

        Task<ApiResponse<LkpVehicleModel>> AddVehicleModelAsync(LkpVehicleModel vehicleModel);
        Task<ApiResponse<LkpVehicleModel>> getVehicleModelByidAsync(int MODELID);
        Task<ApiResponse<List<LkpVehicleModel>>> getVehicleModelAsync();
        Task<ApiResponse<LkpVehicleModel>> updateVehicleModelByidAsync(int MODELID, LkpVehicleModel updatedVehicleModel);
        Task<ApiResponse<LkpVehicleModel>> deleteVehicleModelByid(int MODELID);
    }
}
