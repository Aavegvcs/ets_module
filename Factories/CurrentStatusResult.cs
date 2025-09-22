using WebApplicationETS.Model.Compliances.VehicleCompliances;

namespace WebApplicationETS.Factories
{
    public class CurrentStatusResult
    {
        public bool success { get; private set; }
        public LkpCurrentStatus? currentStatus { get; private set; }
        public string? errorMessage { get; private set; } = string.Empty;

        public static CurrentStatusResult Fail(string message)
        {
            return new CurrentStatusResult { success = false, errorMessage = message };
        }

        public static CurrentStatusResult Ok(LkpCurrentStatus currentStatus)
        {
            return new CurrentStatusResult { success = true, currentStatus = currentStatus };
        }
    }
}
