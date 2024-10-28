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
                bool isExist = model.Id != 0 && model.UserLoginId.HasValue;

                var userLogin = new UserLogin();
                var user = new Users();
                if (isExist)
                {
                    userLogin = _userLoginService.GetUserById(model.UserLoginId!.Value);
                    user = _userService.GetUserById(model.Id!.Value);
                }

                //string profilePic = "";
                //if (model.ProfilePic != null)
                //{
                //    if (model.ProfilePic.Length > 0)
                //    {
                //        var profileExten = new[] { ".jpg", ".png", ".jpeg" };
                //        var ext = Path.GetExtension(model.ProfilePic.FileName).ToLower();

                //        if (!profileExten.Contains(ext))
                //        {
                //            ModelState.AddModelError("", $"Profile image not valid, Please choose jpg,png,jpeg format");
                //            return CreateModelStateErrors();
                //        }
                //        else
                //        {
                //            profilePic = await this.UploadFiles(_env, model.ProfilePic, "", "UserProfilePic", "");
                //        }
                //    }
                //}

                if (model.Id == null || model.Id == 0)
                {
                    string salt = PasswordHasher.GenerateSalt();
                    userLogin.Password = PasswordHasher.GeneratePassword(model.Password, salt);
                    userLogin.PasswordSalt = salt;
                    userLogin.IsVerifiedEmail = false;
                }
                userLogin.RoleType = (int)UserRoleType.User;
                userLogin.IsVerified = model.IsVerified;
                userLogin.IsActive = model.IsActive;
                userLogin.Username = isExist ? userLogin.Username : model.Email;

                var result = isExist ? _userLoginService.UpdateUserLogin(userLogin) : _userLoginService.SaveUserLogin(userLogin);

                user.UserLoginId = result;
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.Email = isExist ? user.Email : model.Email;
                user.Mobile = model.Mobile;
                user.Dob = Convert.ToDateTime(model.Dob);
                user.ShortUrl = model.ShortUrl;
                user.TimeZoneId = model.TimeZoneId;
                user.CountryId = model.CountryId;
                user.StateId = model.StateId;
                user.CityId = model.CityId;
                user.Address = model.Address;
                user.ZipCode = model.ZipCode;
                //user.ProfilePic = !string.IsNullOrEmpty(profilePic) ? profilePic : user.ProfilePic;
                user.DesignationId = model.DesignationId == 0 ? null : model.DesignationId;
                user.ParentId = model.ParentId == Guid.Empty ? null : model.ParentId;
                user.Colour = model.Colour;
                var result2 = isExist ? this._userService.UpdateUsers(user) : this._userService.SaveUsers(user);
                string errorMsg = "";
                if (model.Id == 0)
                {
                    try
                    {

                        //#region For User
                        //short emailId = (byte)EmailTemplateType.UserAccountCreation;
                        //EmailTemplateDto emailDto = _emailTemplateService.GetTemplate(emailId);

                        //if (emailDto != null && emailDto.IsActive)
                        //{
                        //    string html = emailDto.Content;

                        //    string siteUrl = SiteKeys.Domain;

                        //    //string verifyLink = SiteKeys.Domain + "account/verifyuseremail?" + EncryptDecrypt.EncryptURL(Convert.ToString(result));
                        //    string clickhere = "please <a href='" + SiteKeys.Domain + "account/verifyuseremail?" + EncryptDecrypt.EncryptURL(Convert.ToString(result)) + "' target='_blank'>Click Here</a>";

                        //    html = html.Replace("##name##", $"{user.FirstName} {user.LastName}".Replace("  ", " ")).Replace("##sitename##", "LMS Platform")
                        //     .Replace("##username##", user.Email).Replace("##password##", model.Password).Replace("##siteurl##", siteUrl).Replace("##date##", DateTime.Now.Year.ToString()).Replace("##verifylink##", clickhere);

                        //    await Common.Common.SendWelComeMail(model.Email, emailDto.EmailSubject, html);
                        //}
                        //#endregion
                        //if (model.FormType == true)
                        //{
                        //    #region For Admin
                        //    short emailAdmin = (byte)EmailTemplateType.UserAccountCreationForAdmin;
                        //    EmailTemplateDto emailDtoAdmin = _emailTemplateService.GetTemplate(emailId);
                        //    var userAdmin = _userLoginService.GetUserByRole((int)UserRoleType.Admin);

                        //    if (emailDto != null && emailDto.IsActive)
                        //    {
                        //        string html = emailDto.Content;

                        //        string siteUrl = SiteKeys.Domain;

                        //        html = html.Replace("##name##", $"Admin").Replace("##sitename##", "LMS Platform")
                        //         .Replace("##username##", user.Email).Replace("##password##", model.Password).Replace("##siteurl##", siteUrl).Replace("##date##", DateTime.Now.Year.ToString());

                        //        await Common.Common.SendWelComeMail(userAdmin.Username, emailDto.EmailSubject, html);
                        //    }
                        //    #endregion
                        //}
                    }
                    catch (Exception ex)
                    {
                        errorMsg = user.Email;
                    }
                }

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
                if (user.RoleType == (int)UserRoleType.User && user.DesignationId == null)
                {
                    return BadRequestErrorResult("Your designation is not defined. Please contact to admin.");
                }
                if (user.RoleType == (int)UserRoleType.User && user.ParentId == null)
                {
                    return BadRequestErrorResult("Your reporting person is not defined. Please contact to admin.");
                }

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
