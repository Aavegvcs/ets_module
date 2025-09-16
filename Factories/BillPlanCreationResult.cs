using WebApplicationETS.Model.Compliances.VehicleCompliances;

public class BillPlanCreationResult
{
    public bool Success { get; private set; }
    public LkpBillPlanType? BillPlan { get; private set; }
    public string? ErrorMessage { get; private set; } = string.Empty;

    public static BillPlanCreationResult Fail(string message)
    {
        return new BillPlanCreationResult { Success = false, ErrorMessage = message };
    }

    public static BillPlanCreationResult Ok(LkpBillPlanType billPlan)
    {
        return new BillPlanCreationResult { Success = true, BillPlan = billPlan };
    }
}
