using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.otherModel;

namespace WebApplicationETS.Service.CompliancesServices.VehicleServices.VehicleTypeService
{
    public interface IVehicleTypeService
    {
        Task<ApiResponse<LkpVehicleType>> AddVehicleTypeAsync(LkpVehicleType vehicleType);
        Task<ApiResponse<LkpVehicleType>> getVehicleTypeByidAsync(int VEHICLETYPECODE);
        Task<ApiResponse<List<LkpVehicleType>>> getVehicleTypeAsync();
        Task<ApiResponse<LkpVehicleType>> updateVehicleTypeByidAsync(int VEHICLETYPECODE, LkpVehicleType updatedVehicleType);
        Task<ApiResponse<LkpVehicleType>> deleteVehicleTypeByidAsync(int VEHICLETYPECODE);

    }
}
