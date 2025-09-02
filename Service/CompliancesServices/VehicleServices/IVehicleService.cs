
using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.otherModel;

namespace WebApplicationETS.Service.CompliancesServices.VehicleServices
{
    public interface IVehicleService
    {
        Task<ApiResponse<Vehicle>> AddVehicleAsync(Vehicle vehicle); 
    }
}
