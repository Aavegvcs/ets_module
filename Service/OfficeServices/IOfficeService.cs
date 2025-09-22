using WebApplicationETS.Model.Compliances.Office;
using WebApplicationETS.Model.Dtos;
using WebApplicationETS.Model.otherModel;

namespace WebApplicationETS.Service.OfficeServices
{
    public interface IOfficeService
    {
        Task<ApiResponse<Office>> AddOfficeAsync(OfficeDto dto);
        Task<ApiResponse<List<Office>>> GetAllOfficesAsync();
        Task<ApiResponse<Office>> GetOfficeByIdAsync(int officeId);
        Task<ApiResponse<Office>> UpdateOfficeAsync(int officeId, OfficeDto dto);

        
    }
}
