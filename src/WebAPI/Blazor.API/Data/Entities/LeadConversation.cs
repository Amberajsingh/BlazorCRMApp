using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class LeadConversation
{
    public int Id { get; set; }

    public int LeadId { get; set; }

    public string Description { get; set; }

    public DateTime? Date { get; set; }

    public Guid AddedBy { get; set; }

    public virtual UserLogin AddedByNavigation { get; set; }
}
