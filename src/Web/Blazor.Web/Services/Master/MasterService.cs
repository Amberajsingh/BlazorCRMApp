using Shared.Lib.Dto;

namespace Blazor.Web.Services
{
    public interface IMasterService
    {
        #region [Designation]
        Task<BaseApiResponseDto<List<DesignationResponseDto>>> GetDesignations();
        Task<BaseApiResponseDto<DesignationResponseDto>> GetDesignationById(int id);
        Task<BaseApiResponseDto<bool>> ManageDesignation(DesignationRequestDto model);
        Task<BaseApiResponseDto<bool>> DeleteDesignation(int id);
        #endregion
    }
    public class MasterService : IMasterService
    {
        private IHttpService httpService;

        public MasterService(HttpClient _httpClient, IHttpService _httpService)
        {
            httpService = _httpService;
            httpService.Client = _httpClient;
        }

        #region [Designation]
        public async Task<BaseApiResponseDto<List<DesignationResponseDto>>> GetDesignations()
        {
            return await httpService.GetAsync<List<DesignationResponseDto>>($"Master/GetDesignations");
        }
        public async Task<BaseApiResponseDto<DesignationResponseDto>> GetDesignationById(int id)
        {
            return await httpService.GetAsync<DesignationResponseDto>($"Master/GetDesignationById?id={id}");
        }
        public async Task<BaseApiResponseDto<bool>> ManageDesignation(DesignationRequestDto model)
        {
            return await httpService.PostAsync<bool>("Master/ManageDesignation", model);
        }

        public async Task<BaseApiResponseDto<bool>> DeleteDesignation(int id)
        {
            return await httpService.DeleteAsync<bool>($"Master/DeleteDesignation", id);
        }
        #endregion

    }
}
