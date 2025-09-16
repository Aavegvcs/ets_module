namespace WebApplicationETS.Model.DTOs
{
    public class VehicleDto
    {
        public string vehicleRegistrationNo { get; set; } = string.Empty;

        public int vehicleTypeCode { get; set; }
        public int transporterId { get; set; }
        public int bpId { get; set; }

        public string? trackeeId { get; set; }
        public string? trackeeName { get; set; }

        public int vehicleStatus { get; set; }
        public int locCode { get; set; }

        public DateTime vehicleRegistrationDate { get; set; }
        public DateTime? vehicleInductionDate { get; set; }
        public DateTime registrationExpDate { get; set; }
        public DateTime? firstAidKidDate { get; set; }
        public DateTime? fireExtinguisherDate { get; set; }

        public int driverId { get; set; }
        public string? make { get; set; }
        public int model { get; set; }
        public string chassisNo { get; set; } = string.Empty;

        public DateTime? permitExpiryDate { get; set; }
        public DateTime? insuranceExpiryDate { get; set; }
        public DateTime? fitnessExpiryDate { get; set; }
        public DateTime? roadTaxValidityExpiry { get; set; }
        public DateTime? pucExpiryDate { get; set; }

        public int? kmsRunBeforeOnboarding { get; set; }
        public string? insuranceAgencyName { get; set; }
        public string? ownerName { get; set; }
        public DateTime? ccpermitDate { get; set; }
        public string? ownerAddress { get; set; }
        public string? ownerType { get; set; }

        public DateTime? validTokenTaxDate { get; set; }
        public DateTime? passengerTaxDate { get; set; }

        public bool? isGpsInstalled { get; set; }
        public DateTime? gpsInstallationDate { get; set; }
        public int? gpsProviderCode { get; set; }

        public int fuelTypeCode { get; set; }
        public bool? cngEndorsementInRc { get; set; }
        public int? currentStatus { get; set; }
        public bool? mandatorySignage { get; set; }

        public string? engineCapacityCc { get; set; }

        public int? modBy { get; set; }
        public DateTime? modOn { get; set; }
        public DateTime? makeYear { get; set; }

        public string? remarks { get; set; }

        public DateTime createdOn { get; set; }
        public int createdBy { get; set; }
    }
}
