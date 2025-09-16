using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.Dtos;
using WebApplicationETS.Model.otherModel;

namespace WebApplicationETS.Service.CompliancesServices.VehicleServices.BillPlanService
{
    public interface IBillPlanService
    {

        Task<ApiResponse<LkpBillPlanType>> AddBillPlanAsync(BillPlanDto billPlan);
        Task<ApiResponse<LkpBillPlanType>> getBillPlanByidAsync(string id);

        Task<ApiResponse<List<LkpBillPlanType>>> getBillPlanByidAsync();

        Task<ApiResponse<LkpBillPlanType>> updateBillPlanByidAsync(string id, LkpBillPlanType updatedPlan);

        Task<ApiResponse<LkpBillPlanType>> deleteBillPlanByid(string id);
    }
}
