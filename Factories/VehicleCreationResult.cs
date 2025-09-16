using WebApplicationETS.Model.Compliances.VehicleCompliances;

public class VehicleCreationResult
{
    public bool Success { get; set; }
    public Vehicle? Vehicle { get; set; }
    public string? ErrorMessage { get; set; }

    public static VehicleCreationResult Fail(string message) =>
        new VehicleCreationResult { Success = false, ErrorMessage = message };

    public static VehicleCreationResult Ok(Vehicle vehicle) =>
        new VehicleCreationResult { Success = true, Vehicle = vehicle };
}
