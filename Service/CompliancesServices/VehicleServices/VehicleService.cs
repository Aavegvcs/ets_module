using WebApplicationETS.Data;
using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.otherModel;


namespace WebApplicationETS.Service.CompliancesServices.VehicleServices
{
    public class VehicleService: IVehicleService
    {
        private readonly DataContext _context;
        
        public VehicleService(DataContext context)
        {
            _context = context;

        }
        public async Task<ApiResponse<Vehicle>> AddVehicleAsync(Vehicle vehicle)
        {
            if (vehicle == null)
            {
                return new ApiResponse<Vehicle>(false, null, "Invalid vehicle data");
            }

            _context.Vehicles.Add(vehicle);
            await _context.SaveChangesAsync();

            return new ApiResponse<Vehicle>(true, vehicle, "Vehicle added successfully");
        }


    }
}
