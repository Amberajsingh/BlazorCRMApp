using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class LeadComment
{
    public int Id { get; set; }

    public int LeadId { get; set; }

    public int? StatusType { get; set; }

    public string Comment { get; set; }

    public DateTime? Date { get; set; }

    public Guid AddedBy { get; set; }

    public virtual UserLogin AddedByNavigation { get; set; }
}
