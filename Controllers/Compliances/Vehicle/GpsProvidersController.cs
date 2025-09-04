using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Service.CompliancesServices.VehicleServices.GpsProviderService;

namespace WebApplicationETS.Controllers.Compliances.Vehicle
{
    [Route("api/[controller]")]
    [ApiController]
    public class GpsProvidersController : ControllerBase
    {

        private readonly IGpsProviderService gpsProviderService;

        public GpsProvidersController(IGpsProviderService gpsProviderService)
        {
            this.gpsProviderService = gpsProviderService;
        }

        [HttpGet]
        public async Task<IActionResult> getGpsProviderAsync()
        {
            var response = await gpsProviderService.getGpsProviderAsync();
            if (!response.Status)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpGet("id")]
        public async Task<IActionResult> getGpsProviderById([FromQuery] int id)
        {
            var response = await gpsProviderService.getGpsProviderByIdAsync(id);
            if (!response.Status)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> AddGpsProvider([FromBody]  LkpGpsProvider gpsProvider)
        {
            var response = await gpsProviderService.AddGpsProviderAsync(gpsProvider);
            if (!response.Status)
                return BadRequest(response);
            return CreatedAtAction(nameof(AddGpsProvider), response);
        }

        [HttpPut]
        public async Task<IActionResult> updateGpsProviderById([FromQuery] int gpsProvider, LkpGpsProvider updatedGps)
        {
            var response = await gpsProviderService.updateGpsProviderByIdAsync(gpsProvider, updatedGps);
            if (!response.Status)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> deleteGpsProviderById([FromQuery] int id)
        {
            var response = await gpsProviderService.deleteGpsProviderById(id);
            if (!response.Status)
            {
                return BadRequest(response);
            }
            return NoContent();
        }

    }
}
