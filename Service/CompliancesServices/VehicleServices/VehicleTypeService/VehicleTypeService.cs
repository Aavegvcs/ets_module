using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
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

      public async  Task<ApiResponse<LkpVehicleType>> AddVehicleTypeAsync(LkpVehicleType vehicleType)
        {
            if(vehicleType == null)
            {
               return new ApiResponse<LkpVehicleType>(false, null, "Invalid vehicle type data");
            }

            bool exist = await _context.LkpVehicleTypes.AnyAsync(x => x.vehicleTypeDesc == vehicleType.vehicleTypeDesc);
            if (exist)
            {
                return new ApiResponse<LkpVehicleType>(false, null, "vehicleTypeDesc already exist");
            }
            _context.LkpVehicleTypes.Add(vehicleType);
            await _context.SaveChangesAsync();
            return new ApiResponse<LkpVehicleType>(true, vehicleType, "Vehicle type added successfully");
        }

     public async Task<ApiResponse<LkpVehicleType>> getVehicleTypeByidAsync(int VEHICLETYPECODE)
        {
            if(VEHICLETYPECODE == null)
            {
                return new ApiResponse<LkpVehicleType>(false, null, "Invalid vehicle type id");
            }
            var vehicleType = await _context.LkpVehicleTypes.FindAsync(VEHICLETYPECODE);
            if(vehicleType == null)
            {
                return new ApiResponse<LkpVehicleType>(false, null, "Vehicle type not found");
            }
            return new ApiResponse<LkpVehicleType>(true, vehicleType, "Vehicle type fetched successfully");
        }
      public  async Task<ApiResponse<List<LkpVehicleType>>> getVehicleTypeAsync()
        {
            var vehicleTypes = await _context.LkpVehicleTypes.ToListAsync();
            if(vehicleTypes == null || vehicleTypes.Count == 0)
            {
                return new ApiResponse<List<LkpVehicleType>>(false, null, "No vehicle type found");
            }
            return new ApiResponse<List<LkpVehicleType>>(true, vehicleTypes, "Vehicle types fetched successfully");
        }
      public  async Task<ApiResponse<LkpVehicleType>> updateVehicleTypeByidAsync(int VEHICLETYPECODE, LkpVehicleType updatedVehicleType)
        {
            if(VEHICLETYPECODE == null || updatedVehicleType == null)
            {
                return new ApiResponse<LkpVehicleType>(false, null, "Invalid vehicle type data");
            }
            var existingVehicleType = await _context.LkpVehicleTypes.FindAsync(VEHICLETYPECODE);
            if(existingVehicleType == null)
            {
                return new ApiResponse<LkpVehicleType>(false, null, "Vehicle type not found");
            }
            existingVehicleType.locCode = updatedVehicleType.locCode;
            existingVehicleType.vehicleTypeDesc = updatedVehicleType.vehicleTypeDesc;
            existingVehicleType.capacity = updatedVehicleType.capacity;
            existingVehicleType.modBy = updatedVehicleType.modBy;
            existingVehicleType.modOn = updatedVehicleType.modOn;


            _context.LkpVehicleTypes.Update(existingVehicleType);
            await _context.SaveChangesAsync();
            return new ApiResponse<LkpVehicleType>(true, existingVehicleType, "Vehicle type updated successfully");
        }

        public async Task<ApiResponse<LkpVehicleType>> deleteVehicleTypeByidAsync(int VEHICLETYPECODE)
        {
            if(VEHICLETYPECODE == null)
            {
                return new ApiResponse<LkpVehicleType>(false, null, "Invalid vehicle type id");
            }
            var existingVehicleType = await _context.LkpVehicleTypes.FindAsync(VEHICLETYPECODE);
            if(existingVehicleType == null)
            {
                return new ApiResponse<LkpVehicleType>(false, null, "Vehicle type not found");
            }
            _context.LkpVehicleTypes.Remove(existingVehicleType);
            await _context.SaveChangesAsync();
            return new ApiResponse<LkpVehicleType>(true, existingVehicleType, "Vehicle type deleted successfully");
        }

    }
}
