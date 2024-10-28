using Blazor.API.Data;
using Blazor.API.Data.Entities;
using System.ComponentModel;

namespace LMS.Service.Permission
{
    public interface IDesignationPermissionService
    {
        bool DeletePermission(List<DesignationPermission> model);
        DesignationPermission? GetPermission(int id);
        void InsertPermissionList(List<DesignationPermission> permissionList);
        List<int> GetPermissionByDesignationId(long designationId);
    }
    public class DesignationPermissionService : IDesignationPermissionService
    {

        private readonly ApplicationDbContext _DBContext;

        public DesignationPermissionService(ApplicationDbContext dbContext)
        {
            _DBContext = dbContext;
        }

        public bool DeletePermission(List<DesignationPermission> model)
        {
            foreach (var item in model)
            {
                DesignationPermission? entity = GetPermission(item.Id);
                if (entity != null)
                    _DBContext.DesignationPermission.Remove(entity);
            }
            _DBContext.SaveChanges();
            return true;
        }
        public DesignationPermission? GetPermission(int id)
        {
            return _DBContext.DesignationPermission.FirstOrDefault(m => m.Id == id);
        }

        public void InsertPermissionList(List<DesignationPermission> permissionList)
        {
            _DBContext.DesignationPermission.AddRange(permissionList);
        }


        public List<int> GetPermissionByDesignationId(long designationId)
        {
            return _DBContext.DesignationPermission.Where(m => m.Id == designationId).Select(m => m.DesignationPermissionId).ToList();
        }
    }
}
