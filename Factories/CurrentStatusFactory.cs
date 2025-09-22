using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.Dtos.LkpCurrentStatus;

namespace WebApplicationETS.Factories
{
    public class CurrentStatusFactory
    {
        public interface ICurrentStatusFactory
        {
            CurrentStatusResult Create(CurrentStatusDto dto);
        }

        public class CurrentStatusFactoryImpl : ICurrentStatusFactory
        {
            public CurrentStatusResult Create(CurrentStatusDto dto)
            {
                if (dto == null)
                    return CurrentStatusResult.Fail("Current Status data cannot be null");
                if (dto.currentStatusCode <= 0)
                    return CurrentStatusResult.Fail("Current Status code must be a positive integer");
                if (string.IsNullOrWhiteSpace(dto.currentStatusName))
                    return CurrentStatusResult.Fail("Current Status name is required");
                if (!dto.active.HasValue)
                    return CurrentStatusResult.Fail("Active status must be provided");
                var currentStatus = new LkpCurrentStatus
                {
                    currentStatusCode = dto.currentStatusCode,
                    currentStatusName = dto.currentStatusName,
                    active = dto.active
                };
                return CurrentStatusResult.Ok(currentStatus);
            }
        }


    }
}
