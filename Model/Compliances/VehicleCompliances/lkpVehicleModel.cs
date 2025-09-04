using System.ComponentModel.DataAnnotations;

namespace WebApplicationETS.Model.Compliances.VehicleCompliances
{
    public class LkpVehicleModel
    {
        [Key]
        public int? modelId { get; set; }           // Unique ID for model
        public int? locCode { get; set; } //?
        public int?  vehicleTypeCode { get; set; }   // FK to lkpVehicleType
        public string? modelDesc { get; set; }      // Model name (e.g., Swift, Innova)
        public bool? active { get; set; }
        public int?  createdBy { get; set; }
        public DateTime?  createdOn { get; set; }
    }
}
