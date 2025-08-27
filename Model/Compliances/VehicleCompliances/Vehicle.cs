using System.Numerics;

namespace WebApplicationETS.Model.Compliances.VehicleCompliances
{
    public class Vehicle
    {
        public int vehicleid { get; set; }
        public string? vehicle_registration_no { get; set; }
        public int? vehicletypecode { get; set; }
        public int? transporterid { get; set; }
        public int? bpid { get; set; }
        public string? trackee_id { get; set; }
        public string? trackee_name { get; set; }
        public int? vehicle_status { get; set; }
        public int? loccode { get; set; }
        public DateTime? vehicle_registration_date { get; set; }
        public DateTime? vehicle_induction_date { get; set; }
        public string? vehicle_no { get; set; }
        public DateTime? registration_exp_date { get; set; }
        public DateTime? firstaid_kid_date { get; set; }
        public DateTime? fire_extinguisher_date { get; set; }
        public int? driverid { get; set; }
        public string? make { get; set; }
        public string? model { get; set; }
        public string? chassis_no { get; set; }
        public DateTime? permit_expiry_date { get; set; }
        public DateTime? insurance_expiry_date { get; set; }
        public DateTime? fitness_expiry_date { get; set; }
        public DateTime? road_tax_validity_expiry { get; set; }
        public DateTime? puc_expiry_date { get; set; }
        public int? kms_run_before_onboarding { get; set; }
        public string? insurance_agency_name { get; set; }
        public string? owner_name { get; set; }
        public DateTime? ccpermit_date { get; set; }
        public string? owner_address { get; set; }
        public string? owner_type { get; set; }
        public DateTime? valid_token_tax_date { get; set; }
        public DateTime? passenger_tax_date { get; set; }
        public bool? isgpsinstalled { get; set; }
        public DateTime? gps_installation_date { get; set; }
        public int? GPSProviderCode { get; set; }
        public int? FuelTypeCode { get; set; }
        public bool? cng_endorsement_in_rc { get; set; }
        public int? current_status { get; set; }
        public bool? mandatory_signage { get; set; }
        public string? engine_capacity_cc { get; set; }
        public int? modby { get; set; }
        public DateTime? modon { get; set; }
        public DateTime? Makeyear { get; set; }
        public string? Remarks { get; set; }



    }
}
