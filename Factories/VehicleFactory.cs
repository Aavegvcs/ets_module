using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.DTOs;

public interface IVehicleFactory
{
    VehicleCreationResult Create(VehicleDto dto);
}

public class VehicleFactory : IVehicleFactory
{
    public VehicleCreationResult Create(VehicleDto dto)
    {
        if (dto == null)
            return VehicleCreationResult.Fail("Vehicle data cannot be null");

        if (string.IsNullOrWhiteSpace(dto.vehicleRegistrationNo))
            return VehicleCreationResult.Fail("Vehicle registration number is required");

        if (dto.vehicleTypeCode <= 0)
            return VehicleCreationResult.Fail("Vehicle type code must be greater than 0");

        if (dto.transporterId <= 0)
            return VehicleCreationResult.Fail("Transporter Id must be greater than 0");

        if (dto.bpId <= 0)
            return VehicleCreationResult.Fail("BP Id must be greater than 0");

        if (dto.driverId <= 0)
            return VehicleCreationResult.Fail("Driver Id must be greater than 0");

        if (dto.model <= 0)
            return VehicleCreationResult.Fail("Vehicle model code must be greater than 0");

        if (string.IsNullOrWhiteSpace(dto.chassisNo))
            return VehicleCreationResult.Fail("Chassis number is required");

        if (dto.fuelTypeCode <= 0)
            return VehicleCreationResult.Fail("Fuel type code must be greater than 0");

        if (dto.createdBy <= 0)
            return VehicleCreationResult.Fail("CreatedBy must be provided");

        if (dto.vehicleRegistrationDate == default)
            return VehicleCreationResult.Fail("Vehicle registration date is required");

        if (dto.registrationExpDate == default)
            return VehicleCreationResult.Fail("Registration expiry date is required");

        if (dto.registrationExpDate < dto.vehicleRegistrationDate)
            return VehicleCreationResult.Fail("Registration expiry date cannot be earlier than registration date");

        
        // ✅ All validations passed → build Vehicle
        var vehicle = new Vehicle
        {
            vehicleRegistrationNo = dto.vehicleRegistrationNo,
            vehicleTypeCode = dto.vehicleTypeCode,
            transporterId = dto.transporterId,
            bpId = dto.bpId,
            trackeeId = dto.trackeeId,
            trackeeName = dto.trackeeName,
            vehicleStatus = dto.vehicleStatus,
            locCode = dto.locCode,
            vehicleRegistrationDate = dto.vehicleRegistrationDate,
            vehicleInductionDate = dto.vehicleInductionDate,
            registrationExpDate = dto.registrationExpDate,
            firstAidKidDate = dto.firstAidKidDate,
            fireExtinguisherDate = dto.fireExtinguisherDate,
            driverId = dto.driverId,
            Make = dto.make,
            model = dto.model,
            chassisNo = dto.chassisNo,
            permitExpiryDate = dto.permitExpiryDate,
            insuranceExpiryDate = dto.insuranceExpiryDate,
            fitnessExpiryDate = dto.fitnessExpiryDate,
            roadTaxValidityExpiry = dto.roadTaxValidityExpiry,
            pucExpiryDate = dto.pucExpiryDate,
            kmsRunBeforeOnboarding = dto.kmsRunBeforeOnboarding,
            insuranceAgencyName = dto.insuranceAgencyName,
            ownerName = dto.ownerName,
            ccpermitDate = dto.ccpermitDate,
            ownerAddress = dto.ownerAddress,
            ownerType = dto.ownerType,
            validTokenTaxDate = dto.validTokenTaxDate,
            passengerTaxDate = dto.passengerTaxDate,
            isGpsInstalled = dto.isGpsInstalled,
            gpsInstallationDate = dto.gpsInstallationDate,
            gpsProviderCode = dto.gpsProviderCode,
            fuelTypeCode = dto.fuelTypeCode,
            cngEndorsementInRc = dto.cngEndorsementInRc,
            currentStatus = dto.currentStatus,
            mandatorySignage = dto.mandatorySignage,
            engineCapacityCc = dto.engineCapacityCc,
            modBy = dto.modBy,
            modOn = dto.modOn,
            makeYear = dto.makeYear,
            remarks = dto.remarks,
            createdBy = dto.createdBy,
            createdOn = DateTime.UtcNow
        };

        return VehicleCreationResult.Ok(vehicle);
    }
}
