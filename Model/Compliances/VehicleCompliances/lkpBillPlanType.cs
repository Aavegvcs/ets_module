using System.ComponentModel.DataAnnotations;

namespace WebApplicationETS.Model.Compliances.VehicleCompliances
{
    public class LkpBillPlanType
    {
        [Key]
        public string? bptCode { get; set; }

        
        public string? bptName { get; set; }

       
        public bool? active { get; set; }

    
        public int? createdBy { get; set; }

        public int? modBy { get; set; }

        public DateTime? modOn { get; set; }

        public DateTime? createdOn { get; set; } = DateTime.UtcNow;
    }
}
