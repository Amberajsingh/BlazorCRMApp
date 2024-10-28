using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class StatePlan
{
    public long Id { get; set; }

    public long PlanId { get; set; }

    public int StateId { get; set; }

    public byte PlanType { get; set; }

    public bool IsActive { get; set; }

    public virtual Plan Plan { get; set; }

    public virtual StateMaster State { get; set; }
}
