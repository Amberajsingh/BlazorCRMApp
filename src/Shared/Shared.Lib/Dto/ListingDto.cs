using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Lib.Dto
{
    public class ListingFilterDto
    {
        public int PageSize { get; set; } = 10;
        public int PageIndex { get; set; }
        public string? Search { get; set; }
        public int? OrderColumn { get; set; }
        public int? OrderDirection { get; set; }
        public bool HasFilter { get; set; }
    }

    public class PageResponseViewModel<T>
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public List<T> Items { get; set; } = new();
        public bool HasNext { get; set; }
        public bool HasPrevious { get; set; }
    }

    public class DataListingResponseModel
    {
        public int PageNumber { get; set; } = 1;
        public int TotalRecords { get; set; }
        public int FilterRecords { get; set; }
        public bool HasPrevious { get; set; }
        public bool HasNext { get; set; }
        public string? SearchValue { get; set; }
        public bool HasSpinner { get; set; }
    }
}
