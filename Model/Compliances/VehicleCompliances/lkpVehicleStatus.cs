using System.ComponentModel.DataAnnotations;

namespace WebApplicationETS.Model.Compliances.VehicleCompliances
{
    public class lkpVehicleStatus
    {
        [Key]
        public int VehicleStatusCode { get; set; }   // e.g. 1,2,3,4,5,6,7

        [StringLength(100)]
        public string VehicleStatusName { get; set; }   // e.g. Available, Assigned, Login, Logout, etc.

        public bool? Active { get; set; }   // 1 = Active, 0 = Inactive
    }
}
