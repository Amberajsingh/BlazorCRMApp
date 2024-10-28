using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class LeadQualityMaster
{
    public long Id { get; set; }

    public string LeadQuality { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public Guid? ModifiedBy { get; set; }

    public virtual ICollection<Leads> Leads { get; } = new List<Leads>();
}
