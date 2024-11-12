using Shared.Lib.Dto;

namespace Blazor.Web.Services
{
    public interface IFlagService
    {
        #region [Flag]
        Task<BaseApiResponseDto<PageResponseViewModel<FlagDto>>> GetFlags(ListingFilterDto filterDto);
        Task<BaseApiResponseDto<FlagDto>> GetFlagById(long id);
        Task<BaseApiResponseDto<bool>> ManageFlag(FlagRequestDto model);
        Task<BaseApiResponseDto<bool>> DeleteFlag(long id);

        #endregion
    }
    public class FlagService : IFlagService
    {
        private IHttpService httpService;

        public FlagService(HttpClient _httpClient, IHttpService _httpService)
        {
            httpService = _httpService;
            httpService.Client = _httpClient;
        }

        #region [Flag]
        public async Task<BaseApiResponseDto<PageResponseViewModel<FlagDto>>> GetFlags(ListingFilterDto filterDto)
        {
            return await httpService.PostAsync<PageResponseViewModel<FlagDto>>($"Flag/GetFlags", filterDto);
        }
        public async Task<BaseApiResponseDto<FlagDto>> GetFlagById(long id)
        {
            return await httpService.GetAsync<FlagDto>($"Flag/GetFlagById?id={id}");
        }
        public async Task<BaseApiResponseDto<bool>> ManageFlag(FlagRequestDto model)
        {
            return await httpService.PostAsync<bool>("Flag/ManageFlag", model);
        }

        public async Task<BaseApiResponseDto<bool>> DeleteFlag(long id)
        {
            return await httpService.DeleteAsync<bool>($"Flag/DeleteFlag", id);
        }
        #endregion
    }
}
