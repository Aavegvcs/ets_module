using WebApplicationETS.Model.Compliances.VehicleCompliances;

public class BillPlanCreationResult
{
    public bool success { get; private set; }
    public LkpBillPlanType? billPlan { get; private set; }
    public string? errorMessage { get; private set; } = string.Empty;

    public static BillPlanCreationResult Fail(string message)
    {
        return new BillPlanCreationResult { success = false, errorMessage = message };
    }

    public static BillPlanCreationResult Ok(LkpBillPlanType billPlan)
    {
        return new BillPlanCreationResult { success = true, billPlan = billPlan };
    }
}
