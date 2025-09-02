using System.ComponentModel.DataAnnotations;

namespace WebApplicationETS.Model.Compliances.VehicleCompliances
{
    public class lkpVehicleType
    {
        [Key]
        public int VEHICLETYPECODE { get; set; }
        public int LOCCODE { get; set; } //?

        public string VEHICLETYPEDESC { get; set; }
        public short CAPACITY { get; set; }
        public int CREATEDBY { get; set; }
        public DateTime CREATEDON { get; set; }
    }
}
