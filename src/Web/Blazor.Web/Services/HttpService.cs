using Microsoft.AspNetCore.Components;
using Shared.Lib.Dto;
using System.Text.Json;
using System.Text;
using System.Net;
using System.Net.Http.Headers;

namespace Blazor.Web.Services
{
    public interface IHttpService
    {
        HttpClient? Client { get; set; }
        Task<BaseApiResponseDto<T>> GetAsync<T>(string uri);
        Task<BaseApiResponseDto<T>> PostAsync<T>(string uri, object value);
        Task<BaseApiResponseDto<T>> PostMultipartAsync<T>(string uri, MultipartContent content);
        Task<BaseApiResponseDto<T>> PutAsync<T>(string uri, object value);
        Task<BaseApiResponseDto<T>> DeleteAsync<T>(string uri, object value);
    }

    public class HttpService : IHttpService
    {
        private IHttpContextAccessor _httpContextAccessor;

        public HttpClient? Client { get; set; }

        public HttpService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<BaseApiResponseDto<T>> GetAsync<T>(string uri)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, uri);
            return await SendRequest<T>(request);
        }

        public async Task<BaseApiResponseDto<T>> PostAsync<T>(string uri, object value)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, uri);
            request.Content = new StringContent(JsonSerializer.Serialize(value), Encoding.UTF8, "application/json");
            return await SendRequest<T>(request);
        }

        public async Task<BaseApiResponseDto<T>> PostMultipartAsync<T>(string uri, MultipartContent content)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, uri);
            request.Content = content;
            return await SendRequest<T>(request);
        }

        public async Task<BaseApiResponseDto<T>> PutAsync<T>(string uri, object value)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, uri);
            request.Content = new StringContent(JsonSerializer.Serialize(value), Encoding.UTF8, "application/json");
            return await SendRequest<T>(request);
        }

        public async Task<BaseApiResponseDto<T>> DeleteAsync<T>(string uri, object value)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, uri);
            request.Content = new StringContent(JsonSerializer.Serialize(value), Encoding.UTF8, "application/json");
            return await SendRequest<T>(request);
        }


        #region [Private function]
        private async Task<BaseApiResponseDto<T>> SendRequest<T>(HttpRequestMessage request)
        {
            try
            {
                var response = await Client!.SendAsync(request);

                var result = await response.Content.ReadFromJsonAsync<BaseApiResponseDto<T>>();

                if (result == null)
                    throw new InvalidCastException();

                return result;

            }
            catch (HttpRequestException ex)
            {
                return new BaseApiResponseDto<T> { StatusCode = ex.StatusCode, Message = (ex.InnerException ?? ex).Message };
            }
            catch (Exception ex)
            {
                return new BaseApiResponseDto<T> { StatusCode = HttpStatusCode.InternalServerError, Message = (ex.InnerException ?? ex).Message };
            }
        }
        #endregion
    }
}
