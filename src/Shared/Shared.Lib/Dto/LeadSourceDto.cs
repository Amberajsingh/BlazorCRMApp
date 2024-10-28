using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Shared.Lib.Dto
{
    public class LeadSourceDto
    {
        public long Id { get; set; }
        [DisplayName("Name")]
        public string Title { get; set; }
        [DisplayName("Active")]
        public bool IsActive { get; set; }
        [DisplayName("Static")]
        public bool IsStatic { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ModifiedDate { get; set; }

    }



}
