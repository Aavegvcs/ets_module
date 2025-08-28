
using WebApplicationETS.Model.Compliances.VehicleCompliances;

namespace WebApplicationETS.Service.CompliancesServices.VehicleServices
{
    public interface IVehicleService
    {
        Task<Vehicle> AddVehicleAsync(Vehicle vehicle); 
    }
}
