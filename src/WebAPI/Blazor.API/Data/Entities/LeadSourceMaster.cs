using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class LeadSourceMaster
{
    public long Id { get; set; }

    public string Title { get; set; }

    public bool IsActive { get; set; }

    public bool IsStatic { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<Leads> Leads { get; } = new List<Leads>();
}
