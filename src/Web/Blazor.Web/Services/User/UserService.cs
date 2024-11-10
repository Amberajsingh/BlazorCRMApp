﻿using Shared.Lib.Dto;

namespace Blazor.Web.Services
{
    public interface IUserService
    {
        #region [User]
        Task<BaseApiResponseDto<LoginResponseDto>> login(LoginDto model);
        Task<BaseApiResponseDto<bool>> Signup(UsersDto model);
        Task<BaseApiResponseDto<PageResponseViewModel<UserDto>>> GetUsers(ListingFilterDto filterModel);
        Task<BaseApiResponseDto<UsersDto>> GetUserById(int id);
        Task<BaseApiResponseDto<bool>> ManageUser(UsersDto model);
        Task<BaseApiResponseDto<bool>> DeleteUser(int id);
        #endregion
    }
    public class UserService: IUserService
    {
        private IHttpService httpService;

        public UserService(HttpClient _httpClient, IHttpService _httpService)
        {
            httpService = _httpService;
            httpService.Client = _httpClient;
        }

        public async Task<BaseApiResponseDto<LoginResponseDto>> login(LoginDto model)
        {
            return await httpService.PostAsync<LoginResponseDto>("Account/login", model);
        }

        public async Task<BaseApiResponseDto<bool>> Signup(UsersDto model)
        {
            return await httpService.PostAsync<bool>("Account/Signup", model);
        }

        #region [User]
        public async Task<BaseApiResponseDto<PageResponseViewModel<UserDto>>> GetUsers(ListingFilterDto filterModel)
        {
            return await httpService.PostAsync<PageResponseViewModel<UserDto>>($"User/GetUsers", filterModel);
        }
        public async Task<BaseApiResponseDto<UsersDto>> GetUserById(int id)
        {
            return await httpService.GetAsync<UsersDto>($"User/GetUserById?id={id}");
        }
        public async Task<BaseApiResponseDto<bool>> ManageUser(UsersDto model)
        {
            return await httpService.PostAsync<bool>("User/ManageUser", model);
        }

        public async Task<BaseApiResponseDto<bool>> DeleteUser(int id)
        {
            return await httpService.DeleteAsync<bool>($"User/DeleteUser", id);
        }
        #endregion
    }
}
