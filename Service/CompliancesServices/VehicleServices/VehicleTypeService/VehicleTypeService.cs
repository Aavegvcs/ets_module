using Microsoft.EntityFrameworkCore;
using WebApplicationETS.Data;
using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.otherModel;

namespace WebApplicationETS.Service.CompliancesServices.VehicleServices.VehicleTypeService
{
    public class VehicleTypeService : IVehicleTypeService
    {

        private readonly DataContext _context;

        public VehicleTypeService(DataContext context)
        {
            _context = context;
        }

      public async  Task<ApiResponse<lkpVehicleType>> AddVehicleTypeAsync(lkpVehicleType vehicleType)
        {
            if(vehicleType == null)
            {
               return new ApiResponse<lkpVehicleType>(false, null, "Invalid vehicle type data");
            }
            _context.lkpVehicleTypes.Add(vehicleType);
            await _context.SaveChangesAsync();
            return new ApiResponse<lkpVehicleType>(true, vehicleType, "Vehicle type added successfully");
        }

     public async Task<ApiResponse<lkpVehicleType>> getVehicleTypeByidAsync(int VEHICLETYPECODE)
        {
            if(VEHICLETYPECODE == null)
            {
                return new ApiResponse<lkpVehicleType>(false, null, "Invalid vehicle type id");
            }
            var vehicleType = await _context.lkpVehicleTypes.FindAsync(VEHICLETYPECODE);
            if(vehicleType == null)
            {
                return new ApiResponse<lkpVehicleType>(false, null, "Vehicle type not found");
            }
            return new ApiResponse<lkpVehicleType>(true, vehicleType, "Vehicle type fetched successfully");
        }
      public  async Task<ApiResponse<List<lkpVehicleType>>> getVehicleTypeAsync()
        {
            var vehicleTypes = await _context.lkpVehicleTypes.ToListAsync();
            if(vehicleTypes == null || vehicleTypes.Count == 0)
            {
                return new ApiResponse<List<lkpVehicleType>>(false, null, "No vehicle type found");
            }
            return new ApiResponse<List<lkpVehicleType>>(true, vehicleTypes, "Vehicle types fetched successfully");
        }
      public  async Task<ApiResponse<lkpVehicleType>> updateVehicleTypeByidAsync(int VEHICLETYPECODE, lkpVehicleType updatedVehicleType)
        {
            if(VEHICLETYPECODE == null || updatedVehicleType == null)
            {
                return new ApiResponse<lkpVehicleType>(false, null, "Invalid vehicle type data");
            }
            var existingVehicleType = await _context.lkpVehicleTypes.FindAsync(VEHICLETYPECODE);
            if(existingVehicleType == null)
            {
                return new ApiResponse<lkpVehicleType>(false, null, "Vehicle type not found");
            }
            existingVehicleType.LOCCODE = updatedVehicleType.LOCCODE;
            existingVehicleType.VEHICLETYPEDESC = updatedVehicleType.VEHICLETYPEDESC;
            existingVehicleType.CAPACITY = updatedVehicleType.CAPACITY;
            existingVehicleType.CREATEDBY= updatedVehicleType.CREATEDBY;

            _context.lkpVehicleTypes.Update(existingVehicleType);
            await _context.SaveChangesAsync();
            return new ApiResponse<lkpVehicleType>(true, existingVehicleType, "Vehicle type updated successfully");
        }

        public async Task<ApiResponse<lkpVehicleType>> deleteVehicleTypeByidAsync(int VEHICLETYPECODE)
        {
            if(VEHICLETYPECODE == null)
            {
                return new ApiResponse<lkpVehicleType>(false, null, "Invalid vehicle type id");
            }
            var existingVehicleType = await _context.lkpVehicleTypes.FindAsync(VEHICLETYPECODE);
            if(existingVehicleType == null)
            {
                return new ApiResponse<lkpVehicleType>(false, null, "Vehicle type not found");
            }
            _context.lkpVehicleTypes.Remove(existingVehicleType);
            await _context.SaveChangesAsync();
            return new ApiResponse<lkpVehicleType>(true, existingVehicleType, "Vehicle type deleted successfully");
        }

    }
}
