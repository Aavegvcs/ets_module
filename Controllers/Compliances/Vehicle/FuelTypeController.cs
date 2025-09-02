using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Service.CompliancesServices.VehicleServices.FuelTypeService;

namespace WebApplicationETS.Controllers.Compliances.Vehicle
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelTypeController : ControllerBase
    {
       
        private readonly IFuelTypeService fuelTypeService;

        public FuelTypeController(IFuelTypeService fuelTypeService)
        {
            this.fuelTypeService = fuelTypeService;
        }

        [HttpGet]
        public async Task<IActionResult> getFuelType()
        {
            var response =await fuelTypeService.getFuelTypeAsync();
            if (!response.Status)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> addFuel([FromBody] lkpFuelType fuelType)
        {
            var response = await fuelTypeService.AddFuelTypeAsync(fuelType);

            if (!response.Status)
            {
                return BadRequest(response);
            }
            return CreatedAtAction(nameof(addFuel), response);
        }

        [HttpGet("byId")]
        public async Task<IActionResult> getFuelTypeById([FromQuery] int FuelTypeCode)
        {
            var response = await fuelTypeService.getFuelTypeByidAsync(FuelTypeCode);
            if (!response.Status)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> updateFuelTypeById([FromQuery] int FuelTypeCode , lkpFuelType fuelType)
        {
            var response = await fuelTypeService.updateFuelTypeByidAsync(FuelTypeCode, fuelType);

            if (!response.Status)
            {
                return BadRequest(Response);
            }

            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> deleteFuelTypeById([FromQuery] int FuelTypeCode)
        {
            var response = await fuelTypeService.deleteFuelTypeByid(FuelTypeCode);

            if(!response.Status)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

    }
}
