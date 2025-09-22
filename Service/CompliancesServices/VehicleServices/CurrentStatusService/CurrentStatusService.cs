﻿using Microsoft.EntityFrameworkCore;
using WebApplicationETS.Data;
using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.Dtos.LkpCurrentStatus;
using WebApplicationETS.Model.otherModel;
using static WebApplicationETS.Factories.CurrentStatusFactory;

namespace WebApplicationETS.Service.CompliancesServices.VehicleServices.CurrentStatusService
{
    public class CurrentStatusService:ICurrentStatusService
    {

        private readonly DataContext _context;
        private readonly ICurrentStatusFactory _currentStatusFactory;

        public CurrentStatusService(DataContext context, ICurrentStatusFactory currentStatusFactory)
        {
            _context = context;
            _currentStatusFactory = currentStatusFactory;
        }

        //public async Task<ApiResponse<LkpCurrentStatus>> AddCurrentStatusAsync(LkpCurrentStatus currentStatus)
        //{
        //   if(currentStatus == null)
        //    {
        //        return new ApiResponse<LkpCurrentStatus>(false, null, "Invalid current status data");
        //    }
        //    _context.LkpCurrentStatuses.Add(currentStatus);
        //    await _context.SaveChangesAsync();
        //    return new ApiResponse<LkpCurrentStatus>(true, currentStatus, "Current status added successfully");
        //}


        public async Task<ApiResponse<LkpCurrentStatus>> AddCurrentStatusAsync(CurrentStatusDto dto)
        {
            var result = _currentStatusFactory.Create(dto);
            if(!result.success)
            {
                return new ApiResponse<LkpCurrentStatus>(false, null, result.errorMessage);
            }
            var currentStatus = result.currentStatus;

            bool exist=await _context.LkpCurrentStatuses.AnyAsync(x=>x.currentStatusCode==currentStatus.currentStatusCode || x.currentStatusName==currentStatus.currentStatusName);

            if(exist)
            {
                return new ApiResponse<LkpCurrentStatus>(false, null, "Current status with same code or name already exists");
            }
            _context.LkpCurrentStatuses.Add(currentStatus);
            await _context.SaveChangesAsync();
            return new ApiResponse<LkpCurrentStatus>(true, currentStatus, "Current status added successfully");
        }



        public async Task<ApiResponse<LkpCurrentStatus>> getCurrentStatusByIdAsync(int currentStatusCode)
        {
            if(currentStatusCode==null)
            {
                return new ApiResponse<LkpCurrentStatus>(false, null, "Invalid current status id");
            }
            var currentStatus = await _context.LkpCurrentStatuses.FindAsync(currentStatusCode);
            if(currentStatus == null)
            {
                return new ApiResponse<LkpCurrentStatus>(false, null, "Current status not found");
            }
            return new ApiResponse<LkpCurrentStatus>(true, currentStatus, "Current status fetched successfully");
        }

        public async Task<ApiResponse<List<LkpCurrentStatus>>> getCurrentStatusAsync()
        {
            var currentStatuses = await _context.LkpCurrentStatuses.ToListAsync();
            if(currentStatuses == null || currentStatuses.Count == 0)
            {
                return new ApiResponse<List<LkpCurrentStatus>>(false, null, "No current status found");
            }
            return new ApiResponse<List<LkpCurrentStatus>>(true, currentStatuses, "Current statuses fetched successfully");
        }

        public async Task<ApiResponse<LkpCurrentStatus>> updateCurrentStatusByIdAsync(int currentStatusCode, LkpCurrentStatus updatedCurrentStatus)
        {
            if(currentStatusCode==null || updatedCurrentStatus == null)
            {
                return new ApiResponse<LkpCurrentStatus>(false, null, "Invalid current status data");
            }
            var existingCurrentStatus = await _context.LkpCurrentStatuses.FindAsync(currentStatusCode);
            if(existingCurrentStatus == null)
            {
                return new ApiResponse<LkpCurrentStatus>(false, null, "Current status not found");
            }
            existingCurrentStatus.currentStatusName = updatedCurrentStatus.currentStatusName;
            existingCurrentStatus.active = updatedCurrentStatus.active;
            // Update other fields as necessary
            await _context.SaveChangesAsync();
            return new ApiResponse<LkpCurrentStatus>(true, existingCurrentStatus, "Current status updated successfully");
        }

        public async Task<ApiResponse<bool>> deleteCurrentStatusById(int currentStatusCode)
        {
            if(currentStatusCode==null)
            {
                return new ApiResponse<bool>(false, false, "Invalid current status id");
            }
            var existingCurrentStatus = await _context.LkpCurrentStatuses.FindAsync(currentStatusCode);
            if(existingCurrentStatus == null)
            {
                return new ApiResponse<bool>(false, false, "Current status not found");
            }
            _context.LkpCurrentStatuses.Remove(existingCurrentStatus);
            await _context.SaveChangesAsync();
            return new ApiResponse<bool>(true, true, "Current status deleted successfully");
        }


    }
}
