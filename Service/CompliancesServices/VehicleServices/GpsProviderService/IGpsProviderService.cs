using WebApplicationETS.Model.Compliances.VehicleCompliances;
using WebApplicationETS.Model.otherModel;

namespace WebApplicationETS.Service.CompliancesServices.VehicleServices.GpsProviderService
{
    public interface IGpsProviderService
    {

       Task<ApiResponse<LkpGpsProvider>> AddGpsProviderAsync(LkpGpsProvider gpsProvider);
       
       Task<ApiResponse<LkpGpsProvider>> getGpsProviderByIdAsync(int gpsProviderCode);
       Task<ApiResponse<List<LkpGpsProvider>>> getGpsProviderAsync();
       Task<ApiResponse<LkpGpsProvider>> updateGpsProviderByIdAsync(int gpsProviderCode, LkpGpsProvider updatedGpsProvider);
       Task<ApiResponse<bool>> deleteGpsProviderById(int gpsProviderCode);


    }
}
