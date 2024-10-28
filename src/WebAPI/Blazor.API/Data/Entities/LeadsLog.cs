using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class LeadsLog
{
    public long Id { get; set; }

    public int LeadId { get; set; }

    public string Action { get; set; }

    public DateTime CreatedDate { get; set; }

    public Guid CreatedBy { get; set; }

    public Guid ModifiedBy { get; set; }

    public long? FlagId { get; set; }

    public virtual UserLogin CreatedByNavigation { get; set; }

    public virtual FlagMaster Flag { get; set; }

    public virtual Leads Lead { get; set; }

    public virtual UserLogin ModifiedByNavigation { get; set; }
}
