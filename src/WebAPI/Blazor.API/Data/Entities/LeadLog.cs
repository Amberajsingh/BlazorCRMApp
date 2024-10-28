using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class LeadLog
{
    public int Id { get; set; }

    public int LeadId { get; set; }

    public int? LogType { get; set; }

    public string Description { get; set; }

    public DateTime? Date { get; set; }

    public Guid AddedBy { get; set; }

    public virtual UserLogin AddedByNavigation { get; set; }

    public virtual Lead Lead { get; set; }
}
