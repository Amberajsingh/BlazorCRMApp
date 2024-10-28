using System.Net;

namespace Shared.Lib.Dto
{
    public class BaseApiResponseDto<T>
    {
        public HttpStatusCode? StatusCode { get; set; } = HttpStatusCode.OK;
        public T? Data { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; } = string.Empty;
        public string[]? Errors { get; set; }

        public bool HasDataAvailable()
        {
            return IsSuccess && Data != null;
        }
    }
}
