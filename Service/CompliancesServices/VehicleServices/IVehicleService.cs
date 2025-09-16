
using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.DTOs;
using WebApplicationETS.Model.otherModel;

namespace WebApplicationETS.Service.CompliancesServices.VehicleServices
{
    public interface IVehicleService
    {
        Task<ApiResponse<Vehicle>> AddVehicleAsync(VehicleDto dto);

        Task<ApiResponse<List<Vehicle>>> GetAllVehicleAsync();

        Task<ApiResponse<Vehicle>> GetVehicleByIdAsync(int vehicleId);

        Task<ApiResponse<Vehicle>> UpdateVehicleAsync(int vehicleId, VehicleDto dto);

    }
}
