using AutoMapper;
using Blazor.API.Data.Entities;
using Blazor.API.Infrastructure;
using Blazor.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Lib.Dto;
using Shared.Lib.Helper;
using Shared.Lib.Resources;

namespace Blazor.API.Controllers
{
    [Route("[controller]/[action]")]
    public class UserController : BaseController
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> GetUsers([FromBody] ListingFilterDto model)
        {
            try
            {
                List<UsersDto> responseModel = new List<UsersDto>();

                var predicate = PredicateBuilder.True<Users>();

                predicate = predicate.And(m => m.IsDeleted == false);

                if (!string.IsNullOrWhiteSpace(model.Search))
                {
                    model.Search = model.Search.ToLower()?.Trim();
                    predicate = predicate.And(m => m.FirstName.ToLower().StartsWith(model.Search!));
                }

                var result = _userService.GetUsers(predicate, model.OrderColumn, model.OrderDirection);
                //responseModel = _mapper.Map<List<UsersDto>>(result);

                return SuccessResult(result.ToPageList(model.PageIndex, model.PageSize));
            }
            catch (Exception exception)
            {
                return ExceptionErrorResult(BaseResponseMessages.EXCEPTION, exception);
            }
        }

        [HttpGet]
        public IActionResult GetUserById(int id)
        {
            try
            {
                UsersDto responseModel = new UsersDto();

                var result = _userService.GetUserById(id);
                responseModel = _mapper.Map<UsersDto>(result);

                return SuccessResult(responseModel);
            }
            catch (Exception exception)
            {
                return ExceptionErrorResult(BaseResponseMessages.EXCEPTION, exception);
            }
        }

        [HttpPost]
        public IActionResult ManageUser([FromBody] UsersDto model)
        {
            try
            {
                var user = _mapper.Map<Users>(model);
                if (model.Id == 0)
                {
                    string salt = PasswordHasher.GenerateSalt();
                    user.UserLogin = new()
                    {
                        Id = Guid.NewGuid(),
                        Password = PasswordHasher.GeneratePassword(model.Password, salt),
                        PasswordSalt = salt,
                        CreateDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted = false,
                        IsVerified = true,
                        ModifyDate = DateTime.Now,
                        Username = $"{model.FirstName}{model.LastName}",
                        ForgetPasswordLink = "",
                        RoleType = 1
                    };
                }
                
                
                _userService.SaveUsers(user);

                return SuccessResult(true);
            }
            catch (Exception exception)
            {
                return ExceptionErrorResult(BaseResponseMessages.EXCEPTION, exception);
            }
        }

        [HttpDelete]
        public IActionResult DeleteUser([FromBody] int id)
        {
            try
            {
                //_userService.DeleteUserById(id);
                return SuccessResult(true);
            }
            catch (Exception exception)
            {
                return ExceptionErrorResult(BaseResponseMessages.EXCEPTION, exception);
            }
        }
    }
}
