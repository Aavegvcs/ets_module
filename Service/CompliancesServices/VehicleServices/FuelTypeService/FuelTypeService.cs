using Microsoft.EntityFrameworkCore;
using WebApplicationETS.Data;
using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.otherModel;

namespace WebApplicationETS.Service.CompliancesServices.VehicleServices.FuelTypeService
{
    public class FuelTypeService : IFuelTypeService
    {
        private readonly DataContext _context;

        public FuelTypeService(DataContext context)
        {
            _context = context;
        }

        public async Task<ApiResponse<LkpFuelType>> AddFuelTypeAsync(LkpFuelType fuelType)
        {
           if(fuelType == null)
            {
                return new ApiResponse<LkpFuelType>(false, null, "Invalid fuel type data");
            }
            _context.LkpFuelTypes.Add(fuelType);
            await _context.SaveChangesAsync();
            return new ApiResponse<LkpFuelType>(true, fuelType, "Fuel type added successfully");
        }

       public async Task<ApiResponse<LkpFuelType>> getFuelTypeByidAsync(int id)
        {
            if(id==null)
            {
                return new ApiResponse<LkpFuelType>(false, null, "Invalid fuel type id");
            }
            var fuelType = await _context.LkpFuelTypes.FindAsync(id);
            if(fuelType == null)
            {
                return new ApiResponse<LkpFuelType>(false, null, "Fuel type not found");
            }
            return new ApiResponse<LkpFuelType>(true, fuelType, "Fuel type fetched successfully");
        }
        public async Task<ApiResponse<List<LkpFuelType>>> getFuelTypeAsync()
        {
            var fuelTypes = await _context.LkpFuelTypes.ToListAsync();
            if(fuelTypes == null || fuelTypes.Count == 0)
            {
                return new ApiResponse<List<LkpFuelType>>(false, null, "No fuel type found");
            }
            return new ApiResponse<List<LkpFuelType>>(true, fuelTypes, "Fuel types fetched successfully");
        }
        public async Task<ApiResponse<LkpFuelType>> updateFuelTypeByidAsync(int id, LkpFuelType updatedFuelType)
        {
            if(id==null || updatedFuelType == null)
            {
                return new ApiResponse<LkpFuelType>(false, null, "Invalid fuel type data");
            }
            var existingFuelType = await _context.LkpFuelTypes.FindAsync(id);
            if(existingFuelType == null)
            {
                return new ApiResponse<LkpFuelType>(false, null, "Fuel type not found");
            }
            
            existingFuelType.fuelTypeName=updatedFuelType.fuelTypeName;
            existingFuelType.active=updatedFuelType.active;

            await _context.SaveChangesAsync();
            return new ApiResponse<LkpFuelType>(true, existingFuelType, "Fuel type updated successfully");

        }
     public async   Task<ApiResponse<LkpFuelType>> deleteFuelTypeByid(int id)
        {
            if(id==null)
            {
                return new ApiResponse<LkpFuelType>(false, null, "Invalid fuel type id");
            }
            var deletedFuelType = await _context.LkpFuelTypes
                .Where(x=> x.fuelTypeCode == id)
                .ExecuteDeleteAsync();

            if(deletedFuelType == 0)
            {
                    return new ApiResponse<LkpFuelType>(false, null, "Fuel type not found or already deleted");
            }
            return new ApiResponse<LkpFuelType>(true, null, "Fuel type deleted successfully");
        }

    }
}
