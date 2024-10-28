using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class PriorityMaster
{
    public long Id { get; set; }

    public string Title { get; set; }

    public string Color { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<Leads> Leads { get; } = new List<Leads>();
}
