using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Shared.Lib.Dto;
using Shared.Lib.Resources;
using System.Net;

namespace Blazor.API.Controllers
{
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected IActionResult SuccessResult<T>(T model, string message = "The request has been executed successfully")
        {
            return Ok(new BaseApiResponseDto<T>
            {
                Data = model,
                StatusCode = System.Net.HttpStatusCode.OK,
                Message = message,
                IsSuccess = true
            });
        }

        protected IActionResult SuccessWithoutDataResult(string message = "The request has been executed successfully")
        {
            return Ok(new BaseApiResponseDto<object>
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Message = message,
                IsSuccess = true
            });
        }

        protected IActionResult ModelErrorResult(string message, ModelStateDictionary modelState)
        {
            var errors = modelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToArray();
            return BadRequestErrorResult(message, errors);
        }
        protected IActionResult ExceptionErrorResult(string message, Exception exception)
        {
            return ErrorResult(message, new string[] { (exception.InnerException ?? exception).Message });
        }

        protected IActionResult BadRequestErrorResult()
        {
            return BadRequestErrorResult(BaseResponseMessages.REQUIRED_ERROR);
        }

        protected IActionResult BadRequestErrorResult(string message, string[]? errorMessages = null)
        {
            return BadRequest(new BaseApiResponseDto<object>
            {
                StatusCode = HttpStatusCode.BadRequest,
                Message = message,
                Errors = errorMessages,
                IsSuccess = false
            });
        }

        protected IActionResult NotAuthorizedResult(string message, string[]? errorMessages = null)
        {
            return Unauthorized(new BaseApiResponseDto<object>
            {
                StatusCode = HttpStatusCode.Unauthorized,
                Message = message,
                Errors = errorMessages,
                IsSuccess = false
            });
        }

        protected IActionResult ErrorResult(string message, string[]? errorMessages = null)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, new BaseApiResponseDto<object>
            {
                StatusCode = HttpStatusCode.InternalServerError,
                Message = message,
                Errors = errorMessages,
                IsSuccess = false
            });
        }

        protected IActionResult LimitExceededErrorResult(string message, string[]? errorMessages = null)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, new BaseApiResponseDto<object>
            {
                StatusCode = HttpStatusCode.TooManyRequests,
                Message = message,
                Errors = errorMessages,
                IsSuccess = false
            });
        }

        protected IActionResult NotFoundResult(string message, string[]? errorMessages = null)
        {
            return BadRequest(new BaseApiResponseDto<object>
            {
                StatusCode = HttpStatusCode.NotFound,
                Message = message,
                Errors = errorMessages,
                IsSuccess = false
            });
        }
    }
}
