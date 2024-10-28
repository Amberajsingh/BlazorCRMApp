using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Lib.Dto
{
    public class CountryMasterResponseDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string CountryCode { get; set; }
    }

    public class StateMasterResponseDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? CountryId { get; set; }
    }

    public class CityMasterResponseDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? StateId { get; set; }
    }
}
