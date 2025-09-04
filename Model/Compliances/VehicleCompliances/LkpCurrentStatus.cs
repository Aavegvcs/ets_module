using System.ComponentModel.DataAnnotations;

namespace WebApplicationETS.Model.Compliances.VehicleCompliances
{
    public class LkpCurrentStatus
    {

        [Key]
        public int currentStatusCode { get; set; }   // e.g. 1,2,3,4

        [StringLength(100)]
        public string currentStatusName { get; set; }   // e.g. Active, InActive, BlackListed, Relieved

        public bool? active { get; set; }   // 1 = Active, 0 = Inactive
    }
}
