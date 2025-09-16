using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.DTOs;
using WebApplicationETS.Model.otherModel;
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
        public async Task<IActionResult> AddVehicle([FromBody] VehicleDto dto)
        {
            var response = await _vehicleService.AddVehicleAsync(dto);

            if (!response.Status)
                return BadRequest(response);

            return CreatedAtAction(nameof(AddVehicle), new { id = response.Result?.vehicleId }, response);
        }


        [HttpGet]
        public async Task<IActionResult> GetAllVehicleAsync()
        {
            var response = await _vehicleService.GetAllVehicleAsync();
            if (!response.Status)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpGet("id")]
        public async Task<IActionResult> getVehicleByidAsync([FromQuery] int vehicleId)
        {
            var response = await _vehicleService.GetVehicleByIdAsync(vehicleId);
            if (!response.Status)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateVehicleAsync([FromQuery] int vehicleId , VehicleDto updatedVehicleModel)
        {
            var response = await _vehicleService.UpdateVehicleAsync(vehicleId, updatedVehicleModel);

            if (!response.Status)
                return BadRequest(response);

            return Ok(response);
        }



    }
}
