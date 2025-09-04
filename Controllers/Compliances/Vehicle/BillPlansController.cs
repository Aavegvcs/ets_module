using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Service.CompliancesServices.VehicleServices.BillPlanService;

namespace WebApplicationETS.Controllers.Compliances.Vehicle
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillPlansController : ControllerBase
    {

        private readonly IBillPlanService billPlanService;

        public BillPlansController(IBillPlanService billPlanService)
        {
            this.billPlanService = billPlanService;
        }
        
        [HttpPost]
        public async Task<IActionResult> AddBillPan([FromBody] LkpBillPlanType billPlan)
        {
            var response = await billPlanService.AddBillPlanAsync(billPlan);

            if (!response.Status)
                return BadRequest(response);

            return CreatedAtAction(nameof(AddBillPan), response);
        }

        [HttpGet("id")]
        public async Task<IActionResult> getBillPlanById([FromQuery] string id)
        {
            var response =await billPlanService.getBillPlanByidAsync(id);

            if (!response.Status)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

       
        [HttpGet]
        public async Task<IActionResult> getBillPlan()
        {
            var response = await billPlanService.getBillPlanByidAsync();
            if (!response.Status)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> updateBillPlanByid([FromQuery] string id, LkpBillPlanType updatedPlan)
        {
            var response = await billPlanService.updateBillPlnaByidAsync(id, updatedPlan);

            if (!response.Status)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> deleteBillPlanByid([FromQuery] string id)
        {
            var response = await billPlanService.deleteBillPlanByid(id);
            if (!response.Status)
            {
                return BadRequest(response);
            }

            return NoContent();
        }


    }
}
