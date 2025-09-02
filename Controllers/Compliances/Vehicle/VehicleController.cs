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
            var response = await _vehicleService.AddVehicleAsync(vehicle);

            if (!response.Status)
                return BadRequest(response);

            return CreatedAtAction(nameof(AddVehicle), response);
        }

    }
}
