using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class AdminLeadComment
{
    public int Id { get; set; }

    public int AdminLeadId { get; set; }

    public int? StatusType { get; set; }

    public string Comment { get; set; }

    public DateTime? Date { get; set; }

    public Guid AddedBy { get; set; }

    public virtual UserLogin AddedByNavigation { get; set; }

    public virtual AdminLead AdminLead { get; set; }
}
