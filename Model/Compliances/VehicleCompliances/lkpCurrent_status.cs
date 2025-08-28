using System.ComponentModel.DataAnnotations;

namespace WebApplicationETS.Model.Compliances.VehicleCompliances
{
    public class lkpCurrent_status
    {
        [Key]
        public int CurrentStatusCode { get; set; }   // e.g. 1,2,3,4

        [StringLength(100)]
        public string CurrentStatusName { get; set; }   // e.g. Active, InActive, BlackListed, Relieved

        public bool? Active { get; set; }   // 1 = Active, 0 = Inactive
    }
}
