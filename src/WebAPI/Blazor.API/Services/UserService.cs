using Blazor.API.Data;
using Blazor.API.Data.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shared.Lib.Dto;
using Shared.Lib.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.API.Services
{
    public interface IUserService
    {
        List<UserDto> GetUsers(Expression<Func<Users, bool>> expression, int? OrderColumn, int? OrderDirection);
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

        public List<UserDto> GetUsers(Expression<Func<Users, bool>> expression, int? OrderColumn, int? OrderDirection)
        {
            try
            {
                IQueryable<Users> query = _DBContext.Users;
                if (OrderColumn.HasValue)
                {
                    switch (OrderColumn.Value)
                    {
                        case 0:
                            query = query.OrderByDescending(m => m.Id);
                            break;
                        case 1:
                            query = OrderDirection!.Value == (int)Sorting.ASCENDING ? query.OrderBy(m => m.FirstName) : query.OrderByDescending(m => m.FirstName);
                            break;
                        case 2:
                            query = OrderDirection!.Value == (int)Sorting.ASCENDING ? query.OrderBy(m => m.LastName) : query.OrderByDescending(m => m.LastName);
                            break;
                        case 3:
                            query = OrderDirection!.Value == (int)Sorting.ASCENDING ? query.OrderBy(m => m.ModifyDate) : query.OrderByDescending(m => m.ModifyDate);
                            break;
                        case 4:
                            query = OrderDirection!.Value == (int)Sorting.ASCENDING ? query.OrderBy(m => m.IsDeleted) : query.OrderByDescending(m => m.IsDeleted);
                            break;
                    }
                }

                return query.Where(expression).Select(x => new UserDto {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
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
