namespace WebApplicationETS.Model.Compliances.VendorCompliances
{
    public class Vendor
    {
        public int? LOCCODE { get; set; }
        public int? TRANSPORTERID { get; set; }
        public string? VENDOR_NAME { get; set; }
        public int? BPID { get; set; }
        public bool? SINGLEPLAN { get; set; }
        public string? PREFIXTAG { get; set; }
        public string? ADDRESS { get; set; }
        public string? MOBILE { get; set; }
        public string? EMAILID { get; set; }
        public string? REMARKS { get; set; }
        public int? MODBY { get; set; }
        public DateTime? MODON { get; set; }
        public bool? ACTIVE { get; set; }
        public DateTime? ContactFrom { get; set; }
        public DateTime? ContactTo { get; set; }
    }
}
