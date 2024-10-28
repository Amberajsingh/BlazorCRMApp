
using Blazor.API.Data;
using Blazor.API.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Shared.Lib.Dto;
using Shared.Lib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.API.Services
{
    public interface IUserLoginService
    {
        Guid SaveUserLogin(UserLogin user);
        Guid UpdateUserLogin(UserLogin user);
        bool IsUserNameExist(string userName, Guid id);
        UserLoginDto GetUserLogin(string userName);
        UserLogin? GetByUserName(string userName);
        UserLogin? GetUserById(Guid id);
        UserLogin? GetPasswordResetByLink(string passwordResetLink);
        UserLogin? GetUserByEmail(string email);
        void AddRangeUser(List<UserLogin> users);
    }
    public class UserLoginService : IUserLoginService
    {
        private readonly ApplicationDbContext _DBContext;

        public UserLoginService(ApplicationDbContext dbContext)
        {
            _DBContext = dbContext;
        }

        public Guid SaveUserLogin(UserLogin user)
        {
            try
            {
                Guid userId = Guid.NewGuid();
                user.Id = userId;
                user.ForgetPasswordLink = "www.google.com";
                user.CreateDate = DateTime.UtcNow;
                user.ModifyDate = DateTime.UtcNow;
                _DBContext.UserLogin.Add(user);
                _DBContext.SaveChanges();
                return user.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Guid UpdateUserLogin(UserLogin user)
        {
            try
            {
                user.ModifyDate = DateTime.UtcNow;
                _DBContext.UserLogin.Update(user);
                _DBContext.SaveChanges();
                return user.Id;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool IsUserNameExist(string userName, Guid id)
        {
            try
            {
                return _DBContext.UserLogin.Any(a => a.Username.ToLower() == userName.ToLower() && a.Id != id && a.IsDeleted == false);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public UserLoginDto GetUserLogin(string userName)
        {
            var userLogin = new UserLoginDto();
            var loginuser = _DBContext.UserLogin.Include(m => m.UsersUserLogin).FirstOrDefault(x => !x.IsDeleted && x.Username.Equals(userName));

            if (loginuser != null)
            {
                userLogin.Id = loginuser.Id;
                userLogin.Username = loginuser.Username;
                userLogin.IsActive = loginuser.IsActive;
                userLogin.IsVerified = loginuser.IsVerified;
                userLogin.IsVerifiedEmail = loginuser.IsVerifiedEmail;
                userLogin.Password = loginuser.Password;
                userLogin.PasswordSalt = loginuser.PasswordSalt;
                userLogin.RoleType = loginuser.RoleType;
                if (loginuser.RoleType == (int)UserRoleType.Admin)
                {
                    userLogin.Name = "Admin";
                    userLogin.ProfileImage = "/admin/images/default-user-img.jpg";
                }
                else if (loginuser.RoleType == (int)UserRoleType.User)
                {
                    var user = loginuser.UsersUserLogin.FirstOrDefault();
                    userLogin.Name = $"{user.FirstName} {user.LastName}".Replace("  ", " ");
                    userLogin.ProfileImage = !string.IsNullOrEmpty(user.ProfilePic) ? $"/DYF/UserProfilePic/{user.ProfilePic}" : "/admin/images/default-user-img.jpg";
                    userLogin.UserId = user.Id;
                    userLogin.DesignationId = user.DesignationId;
                    userLogin.ParentId = user.ParentId;
                }
            }
            else
            {
                userLogin = null;
            }
            return userLogin;
        }

        public UserLogin? GetByUserName(string userName)
        {
            return _DBContext.UserLogin.FirstOrDefault(x => x.Username.Equals(userName) && x.IsDeleted == false);
        }
        public UserLogin? GetUserById(Guid id)
        {
            return _DBContext.UserLogin.FirstOrDefault(x => x.Id == id && x.IsDeleted == false);
        }

        public UserLogin? GetPasswordResetByLink(string passwordResetLink)
        {
            var result = _DBContext.UserLogin.FirstOrDefault(x => x.ForgetPasswordLink == passwordResetLink && x.IsDeleted == false);
            return result;
        }
        public UserLogin? GetUserByEmail(string email)
        {
            return _DBContext.UserLogin.FirstOrDefault(x => x.Username.ToLower() == email.ToLower() && x.IsDeleted == false);
        }
        public void AddRangeUser(List<UserLogin> users)
        {
            _DBContext.UserLogin.AddRange(users);
            _DBContext.SaveChanges();
        }

    }
}
