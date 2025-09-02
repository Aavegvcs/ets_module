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
       
        public async Task<ApiResponse<lkpBillPlanType>> AddBillPlanAsync(lkpBillPlanType billPlan)
        {
            if(billPlan == null)
            {
                return new ApiResponse<lkpBillPlanType>(false, null, "Invalid bill plan data");
            }

            _context.lkpBillPlanTypes.Add(billPlan);
            await _context.SaveChangesAsync();
            return new ApiResponse<lkpBillPlanType>(true, billPlan, "Bill plan added successfully");
        }


        public async Task<ApiResponse<lkpBillPlanType>> getBillPlanByidAsync(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return new ApiResponse<lkpBillPlanType>(false, null, "Invalid bill id");
            }

            var billPlan = await _context.lkpBillPlanTypes.FindAsync(id);

            if (billPlan == null)
            {
                return new ApiResponse<lkpBillPlanType>(false, null, "Bill plan not found");
            }

            return new ApiResponse<lkpBillPlanType>(true, billPlan, "Bill plan fetched successfully");
        }


        public async Task<ApiResponse<List<lkpBillPlanType>>> getBillPlanByidAsync()
        {
            var billPlans=await _context.lkpBillPlanTypes.ToListAsync();

            if(billPlans==null || billPlans.Count == 0)
            {
                return new ApiResponse<List<lkpBillPlanType>>(false, null, "No bill plan Found");
            }
            return new ApiResponse<List<lkpBillPlanType>>(true, billPlans, "Bill plan fetched Successfully");

            
        }

        public async Task<ApiResponse<lkpBillPlanType>> updateBillPlnaByidAsync(string id, lkpBillPlanType updatedPlan)
        {
            if (string.IsNullOrEmpty(id))
            {
                return new ApiResponse<lkpBillPlanType>(false, null, "Invalid bill id");
            }

            var existingPlan = await _context.lkpBillPlanTypes.FindAsync(id);

            if (existingPlan == null)
            {
                return new ApiResponse<lkpBillPlanType>(false, null, "No bill plan Found");
            }

            existingPlan.BPTCODE = updatedPlan.BPTCODE;
            existingPlan.BPTNAME = updatedPlan.BPTNAME;
            existingPlan.ACTIVE = updatedPlan.ACTIVE;
            existingPlan.ModBy = updatedPlan.ModBy;
            existingPlan.ModOn = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            return new ApiResponse<lkpBillPlanType>(true, existingPlan, "Bill plan updated successfully");
        }


        public async Task<ApiResponse<lkpBillPlanType>> deleteBillPlanByid(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return new ApiResponse<lkpBillPlanType>(false, null, "Invalid bill id");
            }

            // Delete by filter
            var deletedCount = await _context.lkpBillPlanTypes
                .Where(x => x.BPTCODE == id)
                .ExecuteDeleteAsync();

            if (deletedCount == 0)
            {
                return new ApiResponse<lkpBillPlanType>(false, null, "Bill plan not found");
            }

            return new ApiResponse<lkpBillPlanType>(true, null, "Bill plan deleted successfully");
        }

    }
}
