using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationETS.Data;
using WebApplicationETS.Factories;
using WebApplicationETS.Model.Compliances.Office;
using WebApplicationETS.Model.Dtos;
using WebApplicationETS.Service.OfficeServices;

namespace WebApplicationETS.Controllers.office
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeController : ControllerBase
    {


        private readonly IOfficeService _officeService;

        public OfficeController(IOfficeService officeService)
        {
            _officeService = officeService;
        }


        [HttpPost]
        public async Task<IActionResult> AddOffice([FromBody] OfficeDto dto)
        {
            var response =await _officeService.AddOfficeAsync(dto);

            if (!response.Status)
                return BadRequest(response);
            return CreatedAtAction(nameof(AddOffice), new { id = response.Result?.officeId }, response);
        }


        [HttpGet("id")]
        public async Task<IActionResult> getOfficeByIdAsync([FromQuery] int officeId)
        {
            var response = await _officeService.GetOfficeByIdAsync(officeId);

            if (response.Status)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }


        [HttpGet]
        public async Task<IActionResult> getOfficeAsync()
        {
            var response = await _officeService.GetAllOfficesAsync();

            if (!response.Status)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }


        [HttpPut]
        public async Task<IActionResult> updateOfficeById([FromQuery] int officeId, OfficeDto dto)
        {
            var response = await _officeService.UpdateOfficeAsync(officeId, dto);
            if (!response.Status)
                return BadRequest(response);

            return Ok(response);
        }






      

        

    }
}
