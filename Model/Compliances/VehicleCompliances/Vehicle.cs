using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationETS.Model.Compliances.VehicleCompliances
{
    [Index(nameof(VehicleRegistrationNo), IsUnique = true)]
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VehicleId { get; set; }

        // Vehicle registration number (must be unique & not empty)
        [Required(ErrorMessage = "Vehicle Registration No is required")]
        [StringLength(20, ErrorMessage = "Registration No cannot exceed 20 characters")]
        public string VehicleRegistrationNo { get; set; } = string.Empty;

        // Vehicle type reference (lookup table)
        [Range(1, int.MaxValue, ErrorMessage = "Vehicle Type Code must be greater than 0")]
        public int VehicleTypeCode { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "TransporterId must be greater than 0")]
        public int TransporterId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "BPID must be greater than 0")]
        public int Bpid { get; set; }

        [StringLength(50)]
        public string? TrackeeId { get; set; }

        [StringLength(100)]
        public string? TrackeeName { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Vehicle status must be greater than 0")]
        public int VehicleStatus { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Location code must be greater than 0")]
        public int LocCode { get; set; }

        [CustomValidation(typeof(Vehicle), nameof(ValidateDateNotDefault))]
        public DateTime VehicleRegistrationDate { get; set; }

        public DateTime? VehicleInductionDate { get; set; }

        [CustomValidation(typeof(Vehicle), nameof(ValidateDateNotDefault))]
        public DateTime RegistrationExpDate { get; set; }

        public DateTime? FirstAidKidDate { get; set; }
        public DateTime? FireExtinguisherDate { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Driver Id must be greater than 0")]
        public int DriverId { get; set; }

        [StringLength(50)]
        public string? Make { get; set; }

        [Required(ErrorMessage = "Model is required")]
        [StringLength(50)]
        public string Model { get; set; } = string.Empty;

        [Required(ErrorMessage = "Chassis No is required")]
        [StringLength(50)]
        public string ChassisNo { get; set; } = string.Empty;

        public DateTime? PermitExpiryDate { get; set; }
        public DateTime? InsuranceExpiryDate { get; set; }
        public DateTime? FitnessExpiryDate { get; set; }
        public DateTime? RoadTaxValidityExpiry { get; set; }
        public DateTime? PucExpiryDate { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "KmsRunBeforeOnboarding must be positive")]
        public int? KmsRunBeforeOnboarding { get; set; }

        [StringLength(100)]
        public string? InsuranceAgencyName { get; set; }

        [StringLength(100)]
        public string? OwnerName { get; set; }

        public DateTime? CcpermitDate { get; set; }

        [StringLength(200)]
        public string? OwnerAddress { get; set; }

        [StringLength(50)]
        public string? OwnerType { get; set; }

        public DateTime? ValidTokenTaxDate { get; set; }
        public DateTime? PassengerTaxDate { get; set; }
        public bool? IsGpsInstalled { get; set; }
        public DateTime? GpsInstallationDate { get; set; }
        public int? GPSProviderCode { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "FuelTypeCode must be greater than 0")]
        public int FuelTypeCode { get; set; }

        public bool? CngEndorsementInRc { get; set; }
        public int? CurrentStatus { get; set; }
        public bool? MandatorySignage { get; set; }

        [StringLength(20)]
        public string? EngineCapacityCc { get; set; }

        public int? ModBy { get; set; }
        public DateTime? ModOn { get; set; }
        public DateTime? MakeYear { get; set; }

        [StringLength(500)]
        public string? Remarks { get; set; }

        // Audit fields
        [CustomValidation(typeof(Vehicle), nameof(ValidateDateNotDefault))]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        [Range(1, int.MaxValue, ErrorMessage = "CreatedBy must be greater than 0")]
        public int CreatedBy { get; set; }

        // ---- Custom Validator for DateTime ----
        public static ValidationResult? ValidateDateNotDefault(DateTime date, ValidationContext context)
        {
            if (date == default(DateTime))
                return new ValidationResult($"{context.MemberName} must be provided");
            return ValidationResult.Success;
        }
    }
}
