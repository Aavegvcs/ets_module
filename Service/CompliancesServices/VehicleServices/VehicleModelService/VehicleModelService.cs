using Microsoft.EntityFrameworkCore;
using WebApplicationETS.Data;
using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.otherModel;

namespace WebApplicationETS.Service.CompliancesServices.VehicleServices.VehicleModelService
{
    public class VehicleModelService: IVehicleModelService
    {
        private readonly DataContext _context;

        public VehicleModelService(DataContext context)
        {
            _context = context;
        }

        public async Task<ApiResponse<lkpVehicleModel>> AddVehicleModelAsync(lkpVehicleModel vehicleModel)
        {
           if(vehicleModel == null)
            {
                return new ApiResponse<lkpVehicleModel>(false, null, "Invalid vehicle model data");
            }
            _context.lkpVehicleModels.Add(vehicleModel);
            await _context.SaveChangesAsync();
            return new ApiResponse<lkpVehicleModel>(true, vehicleModel, "Vehicle model added successfully");
        }

        public async Task<ApiResponse<lkpVehicleModel>> getVehicleModelByidAsync(int id)
        {
            if(id==null)
            {
                return new ApiResponse<lkpVehicleModel>(false, null, "Invalid vehicle model id");
            }
            var vehicleModel = await _context.lkpVehicleModels.FindAsync(id);
            if(vehicleModel == null)
            {
                return new ApiResponse<lkpVehicleModel>(false, null, "Vehicle model not found");
            }
            return new ApiResponse<lkpVehicleModel>(true, vehicleModel, "Vehicle model fetched successfully");
        }


        public async Task<ApiResponse<List<lkpVehicleModel>>> getVehicleModelAsync()
        {
            var vehicleModels = await _context.lkpVehicleModels.ToListAsync();
            if(vehicleModels == null || vehicleModels.Count == 0)
            {
                return new ApiResponse<List<lkpVehicleModel>>(false, null, "No vehicle model found");
            }
            return new ApiResponse<List<lkpVehicleModel>>(true, vehicleModels, "Vehicle models fetched successfully");
        }

        public async Task<ApiResponse<lkpVehicleModel>> updateVehicleModelByidAsync(int MODELID, lkpVehicleModel updatedVehicleModel)
        {
            if(MODELID == null || updatedVehicleModel == null)
            {
                return new ApiResponse<lkpVehicleModel>(false, null, "Invalid vehicle model data");
            }
            var existingVehicleModel = await _context.lkpVehicleModels.FindAsync(MODELID);
            if(existingVehicleModel == null)
            {
                return new ApiResponse<lkpVehicleModel>(false, null, "Vehicle model not found");
            }
            existingVehicleModel.LOCCODE = updatedVehicleModel.LOCCODE;
            existingVehicleModel.VEHICLETYPECODE = updatedVehicleModel.VEHICLETYPECODE;
            existingVehicleModel.MODELDESC = updatedVehicleModel.MODELDESC;
            existingVehicleModel.ACTIVE = updatedVehicleModel.ACTIVE;
            existingVehicleModel.CREATEDBY = updatedVehicleModel.CREATEDBY;

            // Update other properties as needed
            _context.lkpVehicleModels.Update(existingVehicleModel);
            await _context.SaveChangesAsync();
            return new ApiResponse<lkpVehicleModel>(true, existingVehicleModel, "Vehicle model updated successfully");
        }

        public async Task<ApiResponse<lkpVehicleModel>> deleteVehicleModelByid(int MODELID)
        {
            if (MODELID <= 0)
            {
                return new ApiResponse<lkpVehicleModel>(false, null, "Invalid vehicle model id");
            }
            var vehicleModel = await _context.lkpVehicleModels.FindAsync(MODELID);
            if (vehicleModel == null)
            {
                return new ApiResponse<lkpVehicleModel>(false, null, "Vehicle model not found");
            }
            _context.lkpVehicleModels.Remove(vehicleModel);
            await _context.SaveChangesAsync();
            return new ApiResponse<lkpVehicleModel>(true, vehicleModel, "Vehicle model deleted successfully");
        }
    }
}
