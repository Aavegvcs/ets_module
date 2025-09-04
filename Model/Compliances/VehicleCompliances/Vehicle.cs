using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationETS.Model.Compliances.VehicleCompliances
{
    [Index(nameof(vehicleRegistrationNo), IsUnique = true)]
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int vehicleId { get; set; }

        // Vehicle registration number (must be unique & not empty)
        [Required(ErrorMessage = "Vehicle Registration No is required")]
        [StringLength(20, ErrorMessage = "Registration No cannot exceed 20 characters")]
        
        public string vehicleRegistrationNo { get; set; } = string.Empty;

        // Vehicle type reference (lookup table)
        [Range(1, int.MaxValue, ErrorMessage = "Vehicle Type Code must be greater than 0")]
        public int vehicleTypeCode { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "TransporterId must be greater than 0")]
        public int transporterId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "BPID must be greater than 0")]
        public int bpId { get; set; }

        [StringLength(50)]
        public string? trackeeId { get; set; }

        [StringLength(100)]
        public string? trackeeName { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Vehicle status must be greater than 0")]
        public int vehicleStatus { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Location code must be greater than 0")]
        public int locCode { get; set; }

        [CustomValidation(typeof(Vehicle), nameof(ValidateDateNotDefault))]
        public DateTime vehicleRegistrationDate { get; set; }

        public DateTime? vehicleInductionDate { get; set; }

        [CustomValidation(typeof(Vehicle), nameof(ValidateDateNotDefault))]
        public DateTime registrationExpDate { get; set; }

        public DateTime? firstAidKidDate { get; set; }
        public DateTime? fireExtinguisherDate { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Driver Id must be greater than 0")]
        public int driverId { get; set; }

        [StringLength(50)]
        public string? Make { get; set; }

        [Required(ErrorMessage = "Model is required")]
        [StringLength(50)]
        public string model { get; set; } = string.Empty;

        [Required(ErrorMessage = "Chassis No is required")]
        [StringLength(50)]
        public string chassisNo { get; set; } = string.Empty;

        public DateTime? permitExpiryDate { get; set; }
        public DateTime? insuranceExpiryDate { get; set; }
        public DateTime? fitnessExpiryDate { get; set; }
        public DateTime? roadTaxValidityExpiry { get; set; }
        public DateTime? pucExpiryDate { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "KmsRunBeforeOnboarding must be positive")]
        public int? kmsRunBeforeOnboarding { get; set; }

        [StringLength(100)]
        public string? insuranceAgencyName { get; set; }

        [StringLength(100)]
        public string? ownerName { get; set; }

        public DateTime? ccpermitDate { get; set; }

        [StringLength(200)]
        public string? ownerAddress { get; set; }

        [StringLength(50)]
        public string? ownerType { get; set; }

        public DateTime? validTokenTaxDate { get; set; }
        public DateTime? passengerTaxDate { get; set; }
        public bool? isGpsInstalled { get; set; }
        public DateTime? gpsInstallationDate { get; set; }
        public int? gpsProviderCode { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "FuelTypeCode must be greater than 0")]
        public int fuelTypeCode { get; set; }

        public bool? cngEndorsementInRc { get; set; }
        public int? currentStatus { get; set; }
        public bool? mandatorySignage { get; set; }

        [StringLength(20)]
        public string? engineCapacityCc { get; set; }

        public int? modBy { get; set; }
        public DateTime? modOn { get; set; }
        public DateTime? makeYear { get; set; }

        [StringLength(500)]
        public string? remarks { get; set; }

        // Audit fields
        [CustomValidation(typeof(Vehicle), nameof(ValidateDateNotDefault))]
        public DateTime createdOn { get; set; } = DateTime.UtcNow;

        [Range(1, int.MaxValue, ErrorMessage = "CreatedBy must be greater than 0")]
        public int createdBy { get; set; }

        // ---- Custom Validator for DateTime ----
        public static ValidationResult? ValidateDateNotDefault(DateTime date, ValidationContext context)
        {
            if (date == default(DateTime))
                return new ValidationResult($"{context.MemberName} must be provided");
            return ValidationResult.Success;
        }
    }
}
