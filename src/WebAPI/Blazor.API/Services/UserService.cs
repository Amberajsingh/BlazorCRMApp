using Blazor.API.Data;
using Blazor.API.Data.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shared.Lib.Dto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.API.Services
{
    public interface IUserService
    {
        Task<List<Users>> GetUsers();
        bool IsEmailExist(string email, long id);
        Users? GetUserById(long id);
        long UpdateUsers(Users model);
        long SaveUsers(Users model);
       
    }
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _DBContext;

        public UserService(ApplicationDbContext dbContext)
        {
            _DBContext = dbContext;
        }

        public async Task<List<Users>> GetUsers()
        {
            return await _DBContext.Users.ToListAsync();
        }

        public bool IsEmailExist(string email, long id)
        {
            return _DBContext.Users.Any(a => a.Email.ToLower() == email.ToLower() && a.Id != id && a.IsDeleted == false);
        }
        public Users? GetUserById(long id)
        {
            return _DBContext.Users.FirstOrDefault(m => m.Id == id);
        }

        public long UpdateUsers(Users model)
        {
            try
            {
                model.ModifyDate = DateTime.UtcNow;
                _DBContext.Users.Update(model);
                _DBContext.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            return model.Id;
        }

        public long SaveUsers(Users model)
        {
            try
            {
                model.CreateDate = DateTime.UtcNow;
                model.ModifyDate = DateTime.UtcNow;
                _DBContext.Users.Add(model);
                _DBContext.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            return model.Id;
        }
    }
}
