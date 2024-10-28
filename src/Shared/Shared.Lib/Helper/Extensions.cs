using Shared.Lib.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Lib.Helper
{
    public static class Extensions
    {
        public static PageResponseViewModel<T> ToPageList<T>(this IEnumerable<T> collection, int pageIndex, int pageSize, bool allusers = false)
        {
            PageResponseViewModel<T> result = new PageResponseViewModel<T> { PageIndex = pageIndex, PageSize = pageSize };

            var itemsToSkip = (pageIndex <= 0 ? 0 : (pageIndex - 1) * pageSize);

            result.TotalCount = collection.Count();
            if (allusers)
                result.Items = collection.ToList();
            else
                result.Items = collection.Skip(itemsToSkip).Take(pageSize).ToList();

            result.HasPrevious = pageIndex > 1;
            result.HasNext = (itemsToSkip + pageSize) < result.TotalCount;

            return result;
        }
    }
}
