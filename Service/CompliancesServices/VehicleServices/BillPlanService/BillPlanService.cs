using Microsoft.EntityFrameworkCore;
using WebApplicationETS.Data;
using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.otherModel;

namespace WebApplicationETS.Service.CompliancesServices.VehicleServices.BillPlanService
{
    public class BillPlanService: IBillPlanService
    {
        private readonly DataContext _context;

        public BillPlanService(DataContext context)
        {
            _context = context;

        }
       
        public async Task<ApiResponse<LkpBillPlanType>> AddBillPlanAsync(LkpBillPlanType billPlan)
        {
            if(billPlan == null)
            {
                return new ApiResponse<LkpBillPlanType>(false, null, "Invalid bill plan data");
            }

            _context.LkpBillPlanTypes.Add(billPlan);
            await _context.SaveChangesAsync();
            return new ApiResponse<LkpBillPlanType>(true, billPlan, "Bill plan added successfully");
        }


        public async Task<ApiResponse<LkpBillPlanType>> getBillPlanByidAsync(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return new ApiResponse<LkpBillPlanType>(false, null, "Invalid bill id");
            }

            var billPlan = await _context.LkpBillPlanTypes.FindAsync(id);

            if (billPlan == null)
            {
                return new ApiResponse<LkpBillPlanType>(false, null, "Bill plan not found");
            }

            return new ApiResponse<LkpBillPlanType>(true, billPlan, "Bill plan fetched successfully");
        }


        public async Task<ApiResponse<List<LkpBillPlanType>>> getBillPlanByidAsync()
        {
            var billPlans=await _context.LkpBillPlanTypes.ToListAsync();

            if(billPlans==null || billPlans.Count == 0)
            {
                return new ApiResponse<List<LkpBillPlanType>>(false, null, "No bill plan Found");
            }
            return new ApiResponse<List<LkpBillPlanType>>(true, billPlans, "Bill plan fetched Successfully");

            
        }

        public async Task<ApiResponse<LkpBillPlanType>> updateBillPlnaByidAsync(string id, LkpBillPlanType updatedPlan)
        {
            if (string.IsNullOrEmpty(id))
            {
                return new ApiResponse<LkpBillPlanType>(false, null, "Invalid bill id");
            }

            var existingPlan = await _context.LkpBillPlanTypes.FindAsync(id);

            if (existingPlan == null)
            {
                return new ApiResponse<LkpBillPlanType>(false, null, "No bill plan Found");
            }

            existingPlan.bptCode = updatedPlan.bptCode;
            existingPlan.bptName = updatedPlan.bptName;
            existingPlan.active = updatedPlan.active;
            existingPlan.modBy = updatedPlan.modBy;
            existingPlan.modOn = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            return new ApiResponse<LkpBillPlanType>(true, existingPlan, "Bill plan updated successfully");
        }


        public async Task<ApiResponse<LkpBillPlanType>> deleteBillPlanByid(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return new ApiResponse<LkpBillPlanType>(false, null, "Invalid bill id");
            }

            // Delete by filter
            var deletedCount = await _context.LkpBillPlanTypes
                .Where(x => x.bptCode == id)
                .ExecuteDeleteAsync();

            if (deletedCount == 0)
            {
                return new ApiResponse<LkpBillPlanType>(false, null, "Bill plan not found");
            }

            return new ApiResponse<LkpBillPlanType>(true, null, "Bill plan deleted successfully");
        }

    }
}
