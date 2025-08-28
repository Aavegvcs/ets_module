namespace WebApplicationETS.Model.Compliances.VehicleCompliances
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string? VehicleRegistrationNo { get; set; }
        public int? VehicleTypeCode { get; set; }
        public int? TransporterId { get; set; }
        public int? Bpid { get; set; }
        public string? TrackeeId { get; set; }
        public string? TrackeeName { get; set; }
        public int? VehicleStatus { get; set; }
        public int? LocCode { get; set; }
        public DateTime? VehicleRegistrationDate { get; set; }
        public DateTime? VehicleInductionDate { get; set; }
        public string? VehicleNo { get; set; }
        public DateTime? RegistrationExpDate { get; set; }
        public DateTime? FirstAidKidDate { get; set; }
        public DateTime? FireExtinguisherDate { get; set; }
        public int? DriverId { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? ChassisNo { get; set; }
        public DateTime? PermitExpiryDate { get; set; }
        public DateTime? InsuranceExpiryDate { get; set; }
        public DateTime? FitnessExpiryDate { get; set; }
        public DateTime? RoadTaxValidityExpiry { get; set; }
        public DateTime? PucExpiryDate { get; set; }
        public int? KmsRunBeforeOnboarding { get; set; }
        public string? InsuranceAgencyName { get; set; }
        public string? OwnerName { get; set; }
        public DateTime? CcpermitDate { get; set; }
        public string? OwnerAddress { get; set; }
        public string? OwnerType { get; set; }
        public DateTime? ValidTokenTaxDate { get; set; }
        public DateTime? PassengerTaxDate { get; set; }
        public bool? IsGpsInstalled { get; set; }
        public DateTime? GpsInstallationDate { get; set; }
        public int? GPSProviderCode { get; set; }
        public int? FuelTypeCode { get; set; }
        public bool? CngEndorsementInRc { get; set; }
        public int? CurrentStatus { get; set; }
        public bool? MandatorySignage { get; set; }
        public string? EngineCapacityCc { get; set; }
        public int? ModBy { get; set; }
        public DateTime? ModOn { get; set; }
        public DateTime? MakeYear { get; set; }
        public string? Remarks { get; set; }
    }

}
