using WebApplicationETS.Model.Compliances.Office;
using WebApplicationETS.Model.Dtos;

namespace WebApplicationETS.Factories
{
    public interface IOfficeFactory
    {
        OfficeCreationResult Create(OfficeDto dto);
    }

    public class OfficeFactory : IOfficeFactory
    {
        public OfficeCreationResult Create(OfficeDto dto)
        {
            if (dto == null)
            {
                return OfficeCreationResult.Fail("Invalid office data");
            }

            if (dto.locCode <= 0)
                return OfficeCreationResult.Fail("Location code must be greater than zero");

            if (string.IsNullOrWhiteSpace(dto.locName))
                return OfficeCreationResult.Fail("Location name is required");

            if (dto.lat < -90 || dto.lat > 90)
                return OfficeCreationResult.Fail("Latitude must be between -90 and 90");

            if (dto.lng < -180 || dto.lng > 180)
                return OfficeCreationResult.Fail("Longitude must be between -180 and 180");

            if (string.IsNullOrWhiteSpace(dto.address))
                return OfficeCreationResult.Fail("Address is required");

            if (string.IsNullOrWhiteSpace(dto.city))
                return OfficeCreationResult.Fail("City is required");

            if (string.IsNullOrWhiteSpace(dto.state))
                return OfficeCreationResult.Fail("State is required");

            if (string.IsNullOrWhiteSpace(dto.helpDeskContactNumber))
                return OfficeCreationResult.Fail("Help Desk Contact Number is required");

            if (string.IsNullOrWhiteSpace(dto.sosContactNumber))
                return OfficeCreationResult.Fail("SOS Contact Number is required");

            if (dto.disableTransportCutoffDays < 0)
                return OfficeCreationResult.Fail("Disable Transport Cutoff Days cannot be negative");


            var office = new Office
            {
                locCode = dto.locCode,
                locName = dto.locName,
                lat = dto.lat,
                lng = dto.lng,
                address = dto.address,
                city = dto.city,
                state = dto.state,
                dispName = dto.dispName,
                shortName = dto.shortName,
                locGroup = dto.locGroup,
                cityZone = dto.cityZone,
                active = dto.active,
                modBy = dto.modBy,
                modOn = DateTime.UtcNow,
                isAutoPenalty = dto.isAutoPenalty,
                isPanicSound = dto.isPanicSound,
                helpDeskContactNumber=dto.helpDeskContactNumber,
                disableTransportCutoffDays = dto.disableTransportCutoffDays,
                disableTransportJob = dto.disableTransportJob,
                driverAppIVRNumber = dto.driverAppIVRNumber,
                userAppIVRNumber = dto.userAppIVRNumber,
                createdOn = DateTime.UtcNow,
            };

            return OfficeCreationResult.Ok(office);
        }
    }
}
