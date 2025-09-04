using Microsoft.EntityFrameworkCore;
using WebApplicationETS.Data;
using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.otherModel;

namespace WebApplicationETS.Service.CompliancesServices.VehicleServices.GpsProviderService
{
    public class GpsProviderService:IGpsProviderService
    {
        private readonly DataContext _context;

        public GpsProviderService(DataContext context)
        {
            _context = context;
        }

        public async Task<ApiResponse<LkpGpsProvider>> AddGpsProviderAsync(LkpGpsProvider gpsProvider)
        {
           if(gpsProvider == null)
            {
                return new ApiResponse<LkpGpsProvider>(false, null, "Invalid GPS provider data");
            }
            _context.LkpGpsProviders.Add(gpsProvider);
            await _context.SaveChangesAsync();
            return new ApiResponse<LkpGpsProvider>(true, gpsProvider, "GPS provider added successfully");
        }

        public async Task<ApiResponse<LkpGpsProvider>> getGpsProviderByIdAsync(int gpsProviderCode)
        {
            if(gpsProviderCode==null)
            {
                return new ApiResponse<LkpGpsProvider>(false, null, "Invalid GPS provider id");
            }
            var gpsProvider = await _context.LkpGpsProviders.FindAsync(gpsProviderCode);
            if(gpsProvider == null)
            {
                return new ApiResponse<LkpGpsProvider>(false, null, "GPS provider not found");
            }
            return new ApiResponse<LkpGpsProvider>(true, gpsProvider, "GPS provider fetched successfully");
        }

        public async Task<ApiResponse<List<LkpGpsProvider>>> getGpsProviderAsync()
        {
            var gpsProviders = await _context.LkpGpsProviders.ToListAsync();
            if(gpsProviders == null || gpsProviders.Count == 0)
            {
                return new ApiResponse<List<LkpGpsProvider>>(false, null, "No GPS provider found");
            }
            return new ApiResponse<List<LkpGpsProvider>>(true, gpsProviders, "GPS providers fetched successfully");
        }

        public async Task<ApiResponse<LkpGpsProvider>> updateGpsProviderByIdAsync(int gpsProviderCode, LkpGpsProvider updatedGpsProvider)
        {
            if(gpsProviderCode==null || updatedGpsProvider == null)
            {
                return new ApiResponse<LkpGpsProvider>(false, null, "Invalid GPS provider data");
            }
            var existingGpsProvider = await _context.LkpGpsProviders.FindAsync(gpsProviderCode);
            if(existingGpsProvider == null)
            {
                return new ApiResponse<LkpGpsProvider>(false, null, "GPS provider not found");
            }
            existingGpsProvider.gpsProviderName = updatedGpsProvider.gpsProviderName;
            existingGpsProvider.active = updatedGpsProvider.active;
            _context.LkpGpsProviders.Update(existingGpsProvider);
            await _context.SaveChangesAsync();
            return new ApiResponse<LkpGpsProvider>(true, existingGpsProvider, "GPS provider updated successfully");
        }

        public async Task<ApiResponse<bool>> deleteGpsProviderById(int gpsProviderCode)
        {
            if(gpsProviderCode==null)
            {
                return new ApiResponse<bool>(false, false, "Invalid GPS provider id");
            }
            var existingGpsProvider = await _context.LkpGpsProviders.FindAsync(gpsProviderCode);
            if(existingGpsProvider == null)
            {
                return new ApiResponse<bool>(false, false, "GPS provider not found");
            }
            _context.LkpGpsProviders.Remove(existingGpsProvider);
            await _context.SaveChangesAsync();
            return new ApiResponse<bool>(true, true, "GPS provider deleted successfully");
        }

        


    }
}
