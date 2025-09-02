using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.otherModel;

namespace WebApplicationETS.Service.CompliancesServices.VehicleServices.VehicleTypeService
{
    public interface IVehicleTypeService
    {
        Task<ApiResponse<lkpVehicleType>> AddVehicleTypeAsync(lkpVehicleType vehicleType);
        Task<ApiResponse<lkpVehicleType>> getVehicleTypeByidAsync(int VEHICLETYPECODE);
        Task<ApiResponse<List<lkpVehicleType>>> getVehicleTypeAsync();
        Task<ApiResponse<lkpVehicleType>> updateVehicleTypeByidAsync(int VEHICLETYPECODE, lkpVehicleType updatedVehicleType);
        Task<ApiResponse<lkpVehicleType>> deleteVehicleTypeByidAsync(int VEHICLETYPECODE);

    }
}
