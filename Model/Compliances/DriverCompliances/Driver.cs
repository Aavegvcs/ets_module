namespace WebApplicationETS.Model.Compliances.DriverCompliances
{
    public class Driver
    {
        public int? DRIVERID { get; set; }
        public int? LOCCODE { get; set; }
        public int? TRANSPORTERID { get; set; }
        public string? DRIVER_NAME { get; set; }
        public string? FATHER_NAME { get; set; }
        public string? PRESENT_ADD { get; set; }
        public string? PERMANENT_ADD { get; set; }
        public string? LICENSE_ADD { get; set; }
        public string? VEHICLE_REGISTRATION_NO { get; set; }
        public DateTime? DOB { get; set; }
        public string? GENDER { get; set; }
        public string? MOBILENO { get; set; }
        public bool? IS_MOBILE_DEVICE_INSTALLED { get; set; }
        public string? TRIP_MOBILE_NO { get; set; }
        public string? TS_TRACKER_ID { get; set; }
        public string? TSIMEI { get; set; }
        public string? ALTERNAME_MOBILENO { get; set; }
        public string? EMERGENCY_CONTACT { get; set; }
        public string? LICENSE_NO { get; set; }
        public DateTime? LICENSE_EXP_DATE { get; set; }
        public string? DRV_LIC_AUTHORITY { get; set; }
        public DateTime? LICENSE_ISSUE_DATE { get; set; }
        public DateTime? VENDOR_DOJ { get; set; }
        public bool? ID_CARD_ISSUED { get; set; }
        public decimal? EXPERIENCE { get; set; }
        public bool? BADGE { get; set; }
        public string? BADGE_NO { get; set; }
        public DateTime? BADGE_EXP_DATE { get; set; }
        public DateTime? INDUCTION_DATE { get; set; }
        public string? DRIVER_TYPE { get; set; }
        public string? BLOD_GROUP { get; set; }
        public bool? MED_FITNESS { get; set; }
        public DateTime? MED_FITNESS_DATE { get; set; }
        public DateTime? MED_FITNESS_EXP { get; set; }
        public bool? POLICE_VERIFICATION { get; set; }
        public DateTime? POLICE_VERIFICATION_DATE { get; set; }
        public DateTime? POLICE_VERIFICATION_EXP_DATE { get; set; }
        public string? POLICE_VERIFICATION_CODE { get; set; }
        public bool? INTERNAL_VERIFICATION_DONE { get; set; }
        public int? GOVT_ID_PROOF { get; set; }
        public DateTime? LAST_INTERNAL_VERIFICATION_DATE { get; set; }
        public DateTime? INTERNAL_VERIFICATION_EXP_DATE { get; set; }
        public string? INTERNAL_VERIFICATION_APPROVER { get; set; }
        public DateTime? LAST_EXTERNAL_VERIFICATION_DATE { get; set; }
        public DateTime? EXTERNAL_VERIFICATION_EXP_DATE { get; set; }
        public string? EXTERNAL_VERIFICATION_AGENCY { get; set; }
        public string? TRAINING_STATUS { get; set; }
        public int? CURRENT_STATUS { get; set; }
        public DateTime? LAST_TRAINING_DATE { get; set; }
        public DateTime? MODON { get; set; }
        public int? MODBY { get; set; }
        public string? Profile_Image { get; set; }   // nvarchar(max) → string
        public DateTime? PrivateBGV_Exp_Date { get; set; }
        public string? Remarks { get; set; }

    }
}
