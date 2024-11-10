using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Shared.Lib.Dto
{
    public class FlagRequestDto
    {
        public long Id { get; set; }
        [DisplayName("Flag Name")]
        public string FlagName { get; set; }
        [DisplayName("Flag Colour")]
        public string FlagColor { get; set; }
        [DisplayName("Active")]
        public bool IsActive { get; set; }
        [DisplayName("Dynamic")]
        public bool IsDynamic { get; set; }
    }

    public class FlagDto
    {      
        public long Id { get; set; }
        [DisplayName("Flag Name")]
        public string FlagName { get; set; }
        [DisplayName("Flag Colour")]
        public string FlagColor { get; set; }
        [DisplayName("Active")]
        public bool IsActive { get; set; }
        [DisplayName("Dynamic")]
        public bool IsDynamic { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ModifiedDate { get; set; }
    }
}
