using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.otherModel;

namespace WebApplicationETS.Service.CompliancesServices.VehicleServices.FuelTypeService
{
    public interface IFuelTypeService
    {
        Task<ApiResponse<LkpFuelType>> AddFuelTypeAsync(LkpFuelType fuelType);
        Task<ApiResponse<LkpFuelType>> getFuelTypeByidAsync(int id);
        Task<ApiResponse<List<LkpFuelType>>> getFuelTypeAsync();
        Task<ApiResponse<LkpFuelType>> updateFuelTypeByidAsync(int id, LkpFuelType updatedFuelType);
        Task<ApiResponse<LkpFuelType>> deleteFuelTypeByid(int id);
    }
}
