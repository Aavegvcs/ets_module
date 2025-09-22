using System.ComponentModel.DataAnnotations;

namespace WebApplicationETS.Model.Compliances.VehicleCompliances
{
    public class LkpVehicleStatus
    {
        [Key]
        public int vehicleStatusCode { get; set; }   // e.g. 1,2,3,4,5,6,7

        public string vehicleStatusName { get; set; }   // e.g. Available, Assigned, Login, Logout, etc.

        public bool? active { get; set; }   // 1 = Active, 0 = Inactive
    }
}
