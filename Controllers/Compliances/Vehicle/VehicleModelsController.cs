using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Service.CompliancesServices.VehicleServices.VehicleModelService;

namespace WebApplicationETS.Controllers.Compliances.Vehicle
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleModelsController : ControllerBase
    {
        private readonly IVehicleModelService vehicleModelService;

        public VehicleModelsController(IVehicleModelService vehicleModelService)
        {
            this.vehicleModelService = vehicleModelService;
        }

        [HttpPost]
        public async Task<IActionResult> AddVehicleModel([FromBody] LkpVehicleModel vehicleModel)
        {
            var response = await vehicleModelService.AddVehicleModelAsync(vehicleModel);
            if (!response.Status)
                return BadRequest(response);
            return CreatedAtAction(nameof(AddVehicleModel), response);
        }

        [HttpGet("id")]
        public async Task<IActionResult> getVehicleModelByidAsync([FromQuery] int MODELID)
        {
            var response = await vehicleModelService.getVehicleModelByidAsync(MODELID);
            if (!response.Status)
                return BadRequest(response);

            return Ok(response);


        }

        [HttpGet]
        public async Task<IActionResult> getVehicleModelAsync()
        {
            var response = await vehicleModelService.getVehicleModelAsync();
            if (!response.Status)
                return BadRequest(response);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> updateVehicleModelByid([FromQuery] int MODELID, Model.Compliances.VehicleCompliances.LkpVehicleModel updatedVehicleModel)
        {
            var response = await vehicleModelService.updateVehicleModelByidAsync(MODELID, updatedVehicleModel);
            if (!response.Status)
                return BadRequest(response);

            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> deleteVehicleModelByid([FromQuery] int MODELID)
        {
            var response = await vehicleModelService.deleteVehicleModelByid(MODELID);
            if (!response.Status)
                return BadRequest(response);

            return NoContent();
        }

    }

}
