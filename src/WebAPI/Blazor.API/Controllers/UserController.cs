using AutoMapper;
using Blazor.API.Data.Entities;
using Blazor.API.Infrastructure;
using Blazor.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Lib.Dto;
using Shared.Lib.Enums;
using Shared.Lib.Helper;
using Shared.Lib.Resources;

namespace Blazor.API.Controllers
{
    [Route("[controller]/[action]")]
    public class UserController : BaseController
    {
        private readonly IUserService _userService;
        private readonly IUserLoginService _userLoginService;
        private readonly IMapper _mapper;
        public UserController(IUserService userService, IMapper mapper, IUserLoginService userLoginService)
        {
            _userService = userService;
            _mapper = mapper;
            _userLoginService = userLoginService;
        }

        [HttpPost]
        public async Task<IActionResult> GetUsers([FromBody] ListingFilterDto model)
        {
            try
            {
                List<UsersDto> responseModel = new List<UsersDto>();

                var predicate = PredicateBuilder.True<Users>();

                predicate = predicate.And(m => m.IsDeleted == false && m.UserLogin.RoleType == (int)UserRoleType.User);

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
                responseModel.PrifileImagePath = "https://localhost:7299/uploads/" + result.ProfilePic;
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

        [HttpPost]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserDto model)
        {
            try
            {
                var userLogin = _userLoginService.GetUserById(model.UserLoginId ?? Guid.Empty);
                if (userLogin != null)
                {
                    var user = userLogin.UsersUserLogin.FirstOrDefault();
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName ?? string.Empty;
                    user.Dob = model.Dob;
                    user.DesignationId = model.DesignationId;

                    if (model.ProfileImage == null || model.ProfileImage.Length == 0)
                        return BadRequest("No file uploaded.");

                    var folderPath = Path.Combine("wwwroot", "uploads");
                    Directory.CreateDirectory(folderPath);
                    var fileName = $"{Guid.NewGuid()}.jpg";
                    var filePath = Path.Combine(folderPath, fileName);

                    await System.IO.File.WriteAllBytesAsync(filePath, model.ProfileImage);

                    user.ProfilePic = fileName;
                    _userLoginService.UpdateUserLogin(userLogin);
                    return SuccessResult(true);
                }

                return ErrorResult("User not valid");
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
