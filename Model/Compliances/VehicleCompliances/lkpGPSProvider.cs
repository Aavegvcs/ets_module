using System.ComponentModel.DataAnnotations;

namespace WebApplicationETS.Model.Compliances.VehicleCompliances
{
    public class LkpGpsProvider
    {
        [Key]
        public int gpsProviderCode { get; set; }  // Primary Key
        public string gpsProviderName { get; set; }  // varchar(100)
        public bool? active { get; set; }  // Nullable bit
    }
}
