using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class StatusUpdateMaster
{
    public int Id { get; set; }

    public int LeadId { get; set; }

    public long FlagId { get; set; }

    public string StatusUpdateRecords { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual FlagMaster Flag { get; set; }

    public virtual Leads Lead { get; set; }
}
