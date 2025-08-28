using WebApplicationETS.Data;
using WebApplicationETS.Model.Compliances.VehicleCompliances;


namespace WebApplicationETS.Service.CompliancesServices.VehicleServices
{
    public class VehicleService: IVehicleService
    {
        private readonly DataContext _context;
        
        public VehicleService(DataContext context)
        {
            _context = context;

        }
        public async Task<Vehicle> AddVehicleAsync(Vehicle vehicle)
        {
            _context.Vehicles.Add(vehicle);
            await _context.SaveChangesAsync();
            return vehicle;
        }

    }
}
