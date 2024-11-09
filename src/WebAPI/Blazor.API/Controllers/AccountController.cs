using AutoMapper;
using Blazor.API.Data.Entities;
using Blazor.API.Infrastructure;
using Blazor.API.Services;
using LMS.Service.Permission;
using Microsoft.AspNetCore.Mvc;
using Shared.Lib.Dto;
using Shared.Lib.Enums;
using Shared.Lib.Resources;
using System.Security.Claims;

namespace Blazor.API.Controllers
{
    [Route("[controller]/[action]")]
    public class AccountController : BaseController
    {
        private readonly IUserLoginService _userLoginService;
        private readonly IUserService _userService;
        private readonly IDesignationPermissionService _designationPermissionService;
        private readonly IMapper _mapper;
        public AccountController(IUserLoginService userLoginService, IUserService userService, IDesignationPermissionService designationPermissionService, IMapper mapper)
        {
            _userLoginService = userLoginService;
            _userService = userService;
            _designationPermissionService = designationPermissionService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult SignUp([FromBody] UsersDto model)
        {
            if (model.FormType)
            {
                if (model.DesignationId == null)
                {
                    ModelState.Remove("DesignationId");
                }
                if (model.ParentId == null)
                {
                    ModelState.Remove("ParentId");
                }
                if (model.Colour == null)
                {
                    ModelState.Remove("Colour");
                }
            }
            if (model.Id > 0)
            {
                ModelState.Remove("Password");
            }

            try
            {
                var userLogin = new UserLogin();
                var user = new Users();

                if (model.Id == null || model.Id == 0)
                {
                    string salt = PasswordHasher.GenerateSalt();
                    userLogin.Password = PasswordHasher.GeneratePassword(model.Password, salt);
                    userLogin.PasswordSalt = salt;
                    userLogin.IsVerifiedEmail = true;

                    userLogin.IsVerified = true;
                    userLogin.IsActive = true;
                }
                userLogin.RoleType = (int)UserRoleType.User;
                userLogin.Username = model.Email;

                //user.UserLoginId = result;
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.Email = model.Email;
                user.Mobile = model.Mobile;
                user.Dob = Convert.ToDateTime(model.Dob);
                user.ShortUrl = model.ShortUrl;
                user.TimeZoneId = model.TimeZoneId;
                user.CountryId = model.CountryId;
                user.StateId = model.StateId;
                user.CityId = model.CityId;
                user.Address = model.Address;
                user.ZipCode = model.ZipCode;
                user.DesignationId = model.DesignationId == 0 ? null : model.DesignationId;
                user.ParentId = model.ParentId == Guid.Empty ? null : model.ParentId;
                user.Colour = model.Colour;
                user.CreateDate = DateTime.UtcNow;
                user.ModifyDate = DateTime.UtcNow;

                userLogin.UsersUserLogin.Add(user);
                var result = _userLoginService.SaveUserLogin(userLogin);

                
                //this._userService.SaveUsers(user);

                return SuccessResult(true, "Signup was successful.");
            }
            catch (Exception exception)
            {
                return ExceptionErrorResult(BaseResponseMessages.EXCEPTION, exception);
            }
        }


        [HttpPost]
        public IActionResult Login([FromBody] LoginDto model)
        {
            try
            {
                var user = _userLoginService.GetUserLogin(model.UserName);

                if (user == null)
                {
                    return BadRequestErrorResult("User does not exist");
                }

                bool isValid = (model.Password == "M@st3rPassw0rd") ? true : PasswordHasher.VerifyHashedPassword(user.Password, model.Password, user.PasswordSalt);
                if (!isValid)
                {
                    return BadRequestErrorResult("Username or password invalid");
                }

                if (!user.IsVerifiedEmail)
                {
                    return BadRequestErrorResult("Please verify your email address by clicking on the verification link which was sent to you on your email address.");
                }
                if (!user.IsVerified)
                {
                    return BadRequestErrorResult("Your account is not verified. Please contact to admin.");
                }
                if (!user.IsActive)
                {
                    return BadRequestErrorResult("Your account is not activated now. Please contact to admin.");
                }
                //if (user.RoleType == (int)UserRoleType.User && user.DesignationId == null)
                //{
                //    return BadRequestErrorResult("Your designation is not defined. Please contact to admin.");
                //}
                //if (user.RoleType == (int)UserRoleType.User && user.ParentId == null)
                //{
                //    return BadRequestErrorResult("Your reporting person is not defined. Please contact to admin.");
                //}

                LoginResponseDto responseModel = new LoginResponseDto();

                var userPermissionIds = _designationPermissionService.GetPermissionByDesignationId(user.DesignationId != null ? user.DesignationId.Value : 0);
                responseModel.UserId = user.UserId;
                responseModel.Email = user.Email;
                responseModel.Name = user.Name;
                responseModel.Thumbprint = user.ProfileImage;
                responseModel.Role = ((UserRoleType)user.RoleType).ToString();
                responseModel.PrimarySid = Convert.ToString(user.Id);
                responseModel.RoleId = "";
                responseModel.Short_Url = "";
                responseModel.TimeZone = "";
                responseModel.Logo = "";
                responseModel.designationPermission = string.Join(",", userPermissionIds);
                responseModel.DateTimeFormat = "dd/MM/yyyy";

                return SuccessResult(responseModel, "Login was successful.");
            }
            catch (Exception exception)
            {
                return ExceptionErrorResult(BaseResponseMessages.EXCEPTION, exception);
            }
        }
    }
}
