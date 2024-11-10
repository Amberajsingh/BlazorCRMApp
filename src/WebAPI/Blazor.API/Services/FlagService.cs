using Blazor.API.Data;
using Blazor.API.Data.Entities;
using Shared.Lib.Enums;
using System.Linq.Expressions;

namespace Blazor.API.Services
{
    public interface IFlagService
    {
        #region [Flag Master]
        List<FlagMaster> GetFlags(Expression<Func<FlagMaster, bool>> expression, int? OrderColumn, int? OrderDirection);
        FlagMaster? GetFlagById(int id);
        void AddUpdate(FlagMaster CategoryModal);
        bool DeleteFlagById(int id);
        bool UpdateFlagStatus(int id, bool status);
        bool FlagNameAvailabiltity(long? id, string name);
        #endregion
    }
    public class FlagService : IFlagService
    {
        private readonly ApplicationDbContext _DBContext;

        public FlagService(ApplicationDbContext dbContext)
        {
            _DBContext = dbContext;
        }

        #region [Flag Master]
        public List<FlagMaster> GetFlags(Expression<Func<FlagMaster, bool>> expression, int? OrderColumn, int? OrderDirection)
        {
            try
            {
                IQueryable<FlagMaster> query = _DBContext.FlagMaster;
                if (OrderColumn.HasValue)
                {
                    switch (OrderColumn.Value)
                    {
                        case 0:
                            query = query.OrderByDescending(m => m.Id);
                            break;
                        case 1:
                            query = OrderDirection!.Value == (int)Sorting.ASCENDING ? query.OrderBy(m => m.FlagName) : query.OrderByDescending(m => m.FlagName);
                            break;
                        case 2:
                            query = OrderDirection!.Value == (int)Sorting.ASCENDING ? query.OrderBy(m => m.FlagColor) : query.OrderByDescending(m => m.FlagColor);
                            break;
                        case 3:
                            query = OrderDirection!.Value == (int)Sorting.ASCENDING ? query.OrderBy(m => m.ModifiedDate) : query.OrderByDescending(m => m.ModifiedDate);
                            break;
                        case 4:
                            query = OrderDirection!.Value == (int)Sorting.ASCENDING ? query.OrderBy(m => m.IsActive) : query.OrderByDescending(m => m.IsActive);
                            break;
                    }
                }

                return query.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public FlagMaster? GetFlagById(int id)
        {
            try
            {
                return _DBContext.FlagMaster.FirstOrDefault(m => m.Id == id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool FlagNameAvailabiltity(long? id, string name)
        {
            try
            {
                bool available = true;
                if (id != null && id > 0)
                    available = _DBContext.FlagMaster.Any(m => m.FlagName.ToLower().Trim() == name.ToLower().Trim() && m.Id != id && m.IsDeleted != true);
                else
                    available = _DBContext.FlagMaster.Any(m => m.FlagName.ToLower().Trim() == name.ToLower().Trim() && m.IsDeleted == true);

                return available;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddUpdate(FlagMaster FlagModal)
        {
            try
            {
                var Flag = _DBContext.FlagMaster.FirstOrDefault(m => m.Id == FlagModal.Id);
                if (Flag != null)
                {
                    Flag.FlagName = FlagModal.FlagName;
                    Flag.IsActive = FlagModal.IsActive;
                    Flag.ModifiedDate = DateTime.Now;
                    _DBContext.FlagMaster.Update(Flag);
                }
                else
                {
                    FlagModal.CreatedDate = DateTime.Now;
                    FlagModal.ModifiedDate = DateTime.Now;
                    FlagModal.IsDeleted = false;
                    _DBContext.FlagMaster.Add(FlagModal);
                }
                _DBContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteFlagById(int id)
        {
            try
            {
                var Flag = _DBContext.FlagMaster.FirstOrDefault(m => m.Id == id);
                if (Flag != null)
                {
                    Flag.IsDeleted = true;
                    Flag.ModifiedDate = DateTime.Now;
                    _DBContext.FlagMaster.Update(Flag);
                    _DBContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UpdateFlagStatus(int id, bool status)
        {
            try
            {
                var Flag = _DBContext.FlagMaster.FirstOrDefault(m => m.Id == id);
                if (Flag != null)
                {
                    Flag.IsActive = status;
                    Flag.ModifiedDate = DateTime.Now;
                    _DBContext.FlagMaster.Update(Flag);
                    _DBContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

    }
}
