using System.ComponentModel.DataAnnotations;

namespace WebApplicationETS.Model.Compliances.VehicleCompliances
{
    public class LkpVehicleType
    {
        [Key]
        
        public int vehicleTypeCode { get; set; }
        public int locCode { get; set; } //?
        
        public string vehicleTypeDesc { get; set; }
        public short capacity { get; set; }
        public int createdBy { get; set; }
        public DateTime createdOn { get; set; }

        public int modBy { get; set; }
        public DateTime modOn { get; set; }

    }
}
