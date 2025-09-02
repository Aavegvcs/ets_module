using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.otherModel;

namespace WebApplicationETS.Service.CompliancesServices.VehicleServices.BillPlanService
{
    public interface IBillPlanService
    {

        Task<ApiResponse<lkpBillPlanType>> AddBillPlanAsync(lkpBillPlanType billPlan);
        Task<ApiResponse<lkpBillPlanType>> getBillPlanByidAsync(string id);

        Task<ApiResponse<List<lkpBillPlanType>>> getBillPlanByidAsync();

        Task<ApiResponse<lkpBillPlanType>> updateBillPlnaByidAsync(string id, lkpBillPlanType updatedPlan);

        Task<ApiResponse<lkpBillPlanType>> deleteBillPlanByid(string id);
    }
}
