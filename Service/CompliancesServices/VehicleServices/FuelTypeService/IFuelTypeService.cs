using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.otherModel;

namespace WebApplicationETS.Service.CompliancesServices.VehicleServices.FuelTypeService
{
    public interface IFuelTypeService
    {
        Task<ApiResponse<lkpFuelType>> AddFuelTypeAsync(lkpFuelType fuelType);
        Task<ApiResponse<lkpFuelType>> getFuelTypeByidAsync(int id);
        Task<ApiResponse<List<lkpFuelType>>> getFuelTypeAsync();
        Task<ApiResponse<lkpFuelType>> updateFuelTypeByidAsync(int id, lkpFuelType updatedFuelType);
        Task<ApiResponse<lkpFuelType>> deleteFuelTypeByid(int id);
    }
}
