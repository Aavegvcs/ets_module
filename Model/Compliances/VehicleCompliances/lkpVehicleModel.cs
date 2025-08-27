namespace WebApplicationETS.Model.Compliances.VehicleCompliances
{
    public class lkpVehicleModel
    {
        public int? LOCCODE { get; set; }
        public int? VEHICLETYPECODE { get; set; }   // FK to lkpVehicleType
        public int? MODELID { get; set; }           // Unique ID for model
        public string? MODELDESC { get; set; }      // Model name (e.g., Swift, Innova)
        public bool? ACTIVE { get; set; }
        public int? CREATEDBY { get; set; }
        public DateTime? CREATEDON { get; set; }
    }
}
