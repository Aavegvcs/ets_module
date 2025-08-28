using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationETS.Model.otherModel;
using WebApplicationETS.Model.Compliances.VehicleCompliances;

using WebApplicationETS.Service.CompliancesServices.VehicleServices;

namespace WebApplicationETS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {

        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddVehicle([FromBody] Vehicle vehicle)
        {
            if (vehicle == null)
            {
                return BadRequest(new ApiResponse<string>("failed", null, true, "Invalid vehicle data"));
            }

            var newVehicle = await _vehicleService.AddVehicleAsync(vehicle);

            return Ok(new ApiResponse<Vehicle>("success", newVehicle, false, "Vehicle added successfully"));
        }

    }
}
