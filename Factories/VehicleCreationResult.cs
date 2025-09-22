using WebApplicationETS.Model.Compliances.VehicleCompliances;

public class VehicleCreationResult
{
    public bool success { get; set; }
    public Vehicle? vehicle { get; set; }
    public string? errorMessage { get; set; }

    public static VehicleCreationResult Fail(string message) =>
        new VehicleCreationResult { success = false, errorMessage = message };

    public static VehicleCreationResult Ok(Vehicle vehicle) =>
        new VehicleCreationResult { success = true, vehicle = vehicle };
}
