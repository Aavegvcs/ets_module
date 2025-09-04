using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Service.CompliancesServices.VehicleServices.VehicleStatusService;

namespace WebApplicationETS.Controllers.Compliances.Vehicle
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleStatusesController : ControllerBase
    {

        public readonly IVehicleStatusService vehicleStatusService;

        public VehicleStatusesController(IVehicleStatusService vehicleStatusService)
        {
            this.vehicleStatusService = vehicleStatusService;
        }

        [HttpPost]
        public async Task<IActionResult> AddVehicleStatus([FromBody]  LkpVehicleStatus vehicleStatus)
        {
            var response = await vehicleStatusService.AddVehicleStatusAsync(vehicleStatus);
            if (!response.Status)
                return BadRequest(response);
            return CreatedAtAction(nameof(AddVehicleStatus), response);
        }

        [HttpGet("id")]
        public async Task<IActionResult> getVehicleStatusById([FromQuery] int id)
        {
            var response=await vehicleStatusService.getVehicleStatusByIdAsync(id);
            if (!response.Status)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> getVehicleStatusAsync()
        {
            var response =await vehicleStatusService.getVehicleStatusAsync();
            if (!response.Status)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult>updateVehicleStatusById([FromQuery] int vehicleStatus , LkpVehicleStatus updatedVehicle)
        {
            var response=await vehicleStatusService.updateVehicleStatusByIdAsync(vehicleStatus, updatedVehicle);
            if (!response.Status)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult>deleteVehicleStatusById([FromQuery] int id)
        {
            var response = await vehicleStatusService.deleteVehicleStatusByIdAsync(id);
            if (!response.Status)
            {
                return BadRequest(response);
            }
            return NoContent();
        }


    }
}
