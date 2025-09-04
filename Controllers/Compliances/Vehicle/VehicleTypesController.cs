using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Service.CompliancesServices.VehicleServices.VehicleTypeService;

namespace WebApplicationETS.Controllers.Compliances.Vehicle
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleTypesController : ControllerBase
    {
        private readonly IVehicleTypeService vehicleTypeService;

        public VehicleTypesController(IVehicleTypeService vehicleTypeService)
        {
            this.vehicleTypeService = vehicleTypeService;
        }

        [HttpGet]
        public async Task<IActionResult> getVehicleType()
        {
            var response = await vehicleTypeService.getVehicleTypeAsync();
            if (!response.Status)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> addVehicleType([FromBody] LkpVehicleType vehicleType)
        {
            var response = await vehicleTypeService.AddVehicleTypeAsync(vehicleType);
            if (!response.Status)
            {
                return BadRequest(response);
            }
            return CreatedAtAction(nameof(addVehicleType), response);
        }

        [HttpGet("id")]
        public async Task<IActionResult> getVehicleTypeById([FromQuery] int VehicleTypeCode)
        {
            var response = await vehicleTypeService.getVehicleTypeByidAsync(VehicleTypeCode);
            if (!response.Status)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> updateVehicleTypeById([FromQuery] int VehicleTypeCode, LkpVehicleType vehicleType)
        {
            var response = await vehicleTypeService.updateVehicleTypeByidAsync(VehicleTypeCode, vehicleType);
            if (!response.Status)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> deleteVehicleTypeById([FromQuery] int VehicleTypeCode)
        {
            var response = await vehicleTypeService.deleteVehicleTypeByidAsync(VehicleTypeCode);
            if (!response.Status)
            {
                return BadRequest(response);
            }
            return NoContent();
        }

    }
}
