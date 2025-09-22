using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.Dtos.LkpCurrentStatus;
using WebApplicationETS.Service.CompliancesServices.VehicleServices.CurrentStatusService;

namespace WebApplicationETS.Controllers.Compliances.Vehicle
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrentStatusesController : ControllerBase
    {

        private readonly ICurrentStatusService currentStatusService;

        public CurrentStatusesController(ICurrentStatusService currentStatusService)
        {
            this.currentStatusService = currentStatusService;
        }

        [HttpGet]
        public async Task<IActionResult> getCurrentStatusAsync()
        {
            var response = await currentStatusService.getCurrentStatusAsync();
            if (!response.Status)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpGet("id")]
        public async Task<IActionResult> getCurrentStatusById([FromQuery] int id)
        {
            var response = await currentStatusService.getCurrentStatusByIdAsync(id);
            if (!response.Status)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> AddCurrentStatus([FromBody] CurrentStatusDto dto)
        {
            var response = await currentStatusService.AddCurrentStatusAsync(dto);
            if (!response.Status)
                return BadRequest(response);
            return CreatedAtAction(nameof(AddCurrentStatus), response);
        }

        [HttpPut]
        public async Task<IActionResult> updateCurrentStatusById([FromQuery] int currentStatus, LkpCurrentStatus updatedStatus)
        {
            var response = await currentStatusService.updateCurrentStatusByIdAsync(currentStatus, updatedStatus);
            if (!response.Status)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> deleteCurrentStatusById([FromQuery] int id)
        {
            var response = await currentStatusService.deleteCurrentStatusById(id);
            if (!response.Status)
            {
                return BadRequest(response);
            }
            return NoContent();
        }






    }
}
