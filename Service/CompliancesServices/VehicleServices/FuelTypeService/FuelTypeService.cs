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

        public async Task<ApiResponse<lkpFuelType>> AddFuelTypeAsync(lkpFuelType fuelType)
        {
           if(fuelType == null)
            {
                return new ApiResponse<lkpFuelType>(false, null, "Invalid fuel type data");
            }
            _context.lkpFuelTypes.Add(fuelType);
            await _context.SaveChangesAsync();
            return new ApiResponse<lkpFuelType>(true, fuelType, "Fuel type added successfully");
        }

       public async Task<ApiResponse<lkpFuelType>> getFuelTypeByidAsync(int id)
        {
            if(id==null)
            {
                return new ApiResponse<lkpFuelType>(false, null, "Invalid fuel type id");
            }
            var fuelType = await _context.lkpFuelTypes.FindAsync(id);
            if(fuelType == null)
            {
                return new ApiResponse<lkpFuelType>(false, null, "Fuel type not found");
            }
            return new ApiResponse<lkpFuelType>(true, fuelType, "Fuel type fetched successfully");
        }
        public async Task<ApiResponse<List<lkpFuelType>>> getFuelTypeAsync()
        {
            var fuelTypes = await _context.lkpFuelTypes.ToListAsync();
            if(fuelTypes == null || fuelTypes.Count == 0)
            {
                return new ApiResponse<List<lkpFuelType>>(false, null, "No fuel type found");
            }
            return new ApiResponse<List<lkpFuelType>>(true, fuelTypes, "Fuel types fetched successfully");
        }
        public async Task<ApiResponse<lkpFuelType>> updateFuelTypeByidAsync(int id, lkpFuelType updatedFuelType)
        {
            if(id==null || updatedFuelType == null)
            {
                return new ApiResponse<lkpFuelType>(false, null, "Invalid fuel type data");
            }
            var existingFuelType = await _context.lkpFuelTypes.FindAsync(id);
            if(existingFuelType == null)
            {
                return new ApiResponse<lkpFuelType>(false, null, "Fuel type not found");
            }
            
            existingFuelType.FuelTypeName=updatedFuelType.FuelTypeName;
            existingFuelType.Active=updatedFuelType.Active;

            await _context.SaveChangesAsync();
            return new ApiResponse<lkpFuelType>(true, existingFuelType, "Fuel type updated successfully");

        }
     public async   Task<ApiResponse<lkpFuelType>> deleteFuelTypeByid(int id)
        {
            if(id==null)
            {
                return new ApiResponse<lkpFuelType>(false, null, "Invalid fuel type id");
            }
            var deletedFuelType = await _context.lkpFuelTypes
                .Where(x=> x.FuelTypeCode == id)
                .ExecuteDeleteAsync();

            if(deletedFuelType == 0)
            {
                    return new ApiResponse<lkpFuelType>(false, null, "Fuel type not found or already deleted");
            }
            return new ApiResponse<lkpFuelType>(true, null, "Fuel type deleted successfully");
        }

    }
}
