using System.ComponentModel.DataAnnotations;

namespace WebApplicationETS.Model.Compliances.VehicleCompliances
{
    public class lkpBillPlanType
    {
        [Key]
        public string? BPTCODE { get; set; }

        
        public string? BPTNAME { get; set; }

       
        public bool? ACTIVE { get; set; }

    
        public int? createdby { get; set; }

        public int? ModBy { get; set; }

        public DateTime? ModOn { get; set; }

        [Required(ErrorMessage = "CreatedOn is required.")]
        public DateTime? createdon { get; set; } = DateTime.UtcNow;
    }
}
