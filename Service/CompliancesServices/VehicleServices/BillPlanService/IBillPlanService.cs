using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.otherModel;

namespace WebApplicationETS.Service.CompliancesServices.VehicleServices.BillPlanService
{
    public interface IBillPlanService
    {

        Task<ApiResponse<LkpBillPlanType>> AddBillPlanAsync(LkpBillPlanType billPlan);
        Task<ApiResponse<LkpBillPlanType>> getBillPlanByidAsync(string id);

        Task<ApiResponse<List<LkpBillPlanType>>> getBillPlanByidAsync();

        Task<ApiResponse<LkpBillPlanType>> updateBillPlnaByidAsync(string id, LkpBillPlanType updatedPlan);

        Task<ApiResponse<LkpBillPlanType>> deleteBillPlanByid(string id);
    }
}
