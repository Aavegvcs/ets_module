namespace WebApplicationETS.Model.Compliances.VehicleCompliances
{
    public class lkpGPSProvider
    {
        public int GPSProviderCode { get; set; }  // Primary Key
        public string GPSProviderName { get; set; }  // varchar(100)
        public bool? Active { get; set; }  // Nullable bit
    }
}
