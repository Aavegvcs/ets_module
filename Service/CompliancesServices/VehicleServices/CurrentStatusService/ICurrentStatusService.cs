﻿using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.Dtos.LkpCurrentStatus;
using WebApplicationETS.Model.otherModel;

namespace WebApplicationETS.Service.CompliancesServices.VehicleServices.CurrentStatusService
{
    public interface ICurrentStatusService
    {
        
        Task<ApiResponse<LkpCurrentStatus>> AddCurrentStatusAsync(CurrentStatusDto dto);
        Task<ApiResponse<LkpCurrentStatus>> getCurrentStatusByIdAsync(int currentStatusCode);
        Task<ApiResponse<List<LkpCurrentStatus>>> getCurrentStatusAsync();
        Task<ApiResponse<LkpCurrentStatus>> updateCurrentStatusByIdAsync(int currentStatusCode, LkpCurrentStatus updatedCurrentStatus);
        Task<ApiResponse<bool>> deleteCurrentStatusById(int currentStatusCode);
    }
}
