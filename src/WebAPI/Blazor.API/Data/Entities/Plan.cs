using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class Plan
{
    public long Id { get; set; }

    public long ProductId { get; set; }

    public string Name { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public virtual Product Product { get; set; }

    public virtual ICollection<StatePlan> StatePlan { get; } = new List<StatePlan>();
}
