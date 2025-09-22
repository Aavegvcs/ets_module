using WebApplicationETS.Model.Compliances.Office;

namespace WebApplicationETS.Factories
{
    public class OfficeCreationResult
    {
        public bool success { get; private set; }
        public Office? office { get; private set; }
        public string? errorMessage { get; private set; } = string.Empty;

        public static OfficeCreationResult Fail(string message)
        {
            return new OfficeCreationResult { success = false, errorMessage = message };
        }
        public static OfficeCreationResult Ok(Office office)
        {
            return new OfficeCreationResult { success = true, office = office };
        }

    }
}
