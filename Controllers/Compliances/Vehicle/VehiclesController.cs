using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationETS.Model.otherModel;
using WebApplicationETS.Model.Compliances.VehicleCompliances;

using WebApplicationETS.Service.CompliancesServices.VehicleServices;

namespace WebApplicationETS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {

        private readonly IVehicleService _vehicleService;

        public VehiclesController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpPost]
        public async Task<IActionResult> AddVehicle([FromBody] Vehicle vehicle)
        {
            var response = await _vehicleService.AddVehicleAsync(vehicle);

            if (!response.Status)
                return BadRequest(response);

            return CreatedAtAction(nameof(AddVehicle), response);
        }


    }
}
