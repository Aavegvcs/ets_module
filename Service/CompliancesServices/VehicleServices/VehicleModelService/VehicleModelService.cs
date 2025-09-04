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

        public async Task<ApiResponse<LkpVehicleModel>> AddVehicleModelAsync(LkpVehicleModel vehicleModel)
        {
           if(vehicleModel == null)
            {
                return new ApiResponse<LkpVehicleModel>(false, null, "Invalid vehicle model data");
            }
            _context.LkpVehicleModels.Add(vehicleModel);
            await _context.SaveChangesAsync();
            return new ApiResponse<LkpVehicleModel>(true, vehicleModel, "Vehicle model added successfully");
        }

        public async Task<ApiResponse<LkpVehicleModel>> getVehicleModelByidAsync(int id)
        {
            if(id==null)
            {
                return new ApiResponse<LkpVehicleModel>(false, null, "Invalid vehicle model id");
            }
            var vehicleModel = await _context.LkpVehicleModels.FindAsync(id);
            if(vehicleModel == null)
            {
                return new ApiResponse<LkpVehicleModel>(false, null, "Vehicle model not found");
            }
            return new ApiResponse<LkpVehicleModel>(true, vehicleModel, "Vehicle model fetched successfully");
        }


        public async Task<ApiResponse<List<LkpVehicleModel>>> getVehicleModelAsync()
        {
            var vehicleModels = await _context.LkpVehicleModels.ToListAsync();
            if(vehicleModels == null || vehicleModels.Count == 0)
            {
                return new ApiResponse<List<LkpVehicleModel>>(false, null, "No vehicle model found");
            }
            return new ApiResponse<List<LkpVehicleModel>>(true, vehicleModels, "Vehicle models fetched successfully");
        }

        public async Task<ApiResponse<LkpVehicleModel>> updateVehicleModelByidAsync(int MODELID, LkpVehicleModel updatedVehicleModel)
        {
            if(MODELID == null || updatedVehicleModel == null)
            {
                return new ApiResponse<LkpVehicleModel>(false, null, "Invalid vehicle model data");
            }
            var existingVehicleModel = await _context.LkpVehicleModels.FindAsync(MODELID);
            if(existingVehicleModel == null)
            {
                return new ApiResponse<LkpVehicleModel>(false, null, "Vehicle model not found");
            }
            existingVehicleModel.locCode = updatedVehicleModel.locCode;
            existingVehicleModel.vehicleTypeCode = updatedVehicleModel.vehicleTypeCode;
            existingVehicleModel.modelDesc = updatedVehicleModel.modelDesc;
            existingVehicleModel.active = updatedVehicleModel.active;
            existingVehicleModel.createdBy = updatedVehicleModel.createdBy;

            // Update other properties as needed
            _context.LkpVehicleModels.Update(existingVehicleModel);
            await _context.SaveChangesAsync();
            return new ApiResponse<LkpVehicleModel>(true, existingVehicleModel, "Vehicle model updated successfully");
        }

        public async Task<ApiResponse<LkpVehicleModel>> deleteVehicleModelByid(int MODELID)
        {
            if (MODELID <= 0)
            {
                return new ApiResponse<LkpVehicleModel>(false, null, "Invalid vehicle model id");
            }
            var vehicleModel = await _context.LkpVehicleModels.FindAsync(MODELID);
            if (vehicleModel == null)
            {
                return new ApiResponse<LkpVehicleModel>(false, null, "Vehicle model not found");
            }
            _context.LkpVehicleModels.Remove(vehicleModel);
            await _context.SaveChangesAsync();
            return new ApiResponse<LkpVehicleModel>(true, vehicleModel, "Vehicle model deleted successfully");
        }
    }
}
