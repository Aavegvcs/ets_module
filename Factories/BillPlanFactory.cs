using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.Dtos;

namespace WebApplicationETS.Factories   // 👈 choose the correct namespace
{
    public interface IBillPlanFactory
    {
        BillPlanCreationResult Create(BillPlanDto dto);
    }

    public class BillPlanFactory : IBillPlanFactory
    {
        public BillPlanCreationResult Create(BillPlanDto dto)
        {
            if (dto == null)
                return BillPlanCreationResult.Fail("Bill Plan data cannot be null");

            if (string.IsNullOrWhiteSpace(dto.bptCode))
                return BillPlanCreationResult.Fail("Bill Plan code is required");

            if (string.IsNullOrWhiteSpace(dto.bptName))
                return BillPlanCreationResult.Fail("Bill Plan name is required");

            if (!dto.active.HasValue)
                return BillPlanCreationResult.Fail("Active status must be provided");

            if (!dto.modBy.HasValue || dto.modBy <= 0)
                return BillPlanCreationResult.Fail("Modified By must be a valid user id");

            var billPlan = new LkpBillPlanType
            {
                bptCode = dto.bptCode,
                bptName = dto.bptName,
                active = dto.active,
                modBy = dto.modBy,
                modOn = DateTime.UtcNow,
                createdOn = DateTime.UtcNow,
                createdBy = dto.modBy
            };

            return BillPlanCreationResult.Ok(billPlan);
        }
    }
}
