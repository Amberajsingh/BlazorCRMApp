using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class LeadEvent
{
    public int Id { get; set; }

    public int LeadId { get; set; }

    public Guid UserId { get; set; }

    public DateTime EventDate { get; set; }

    public string Note { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public virtual UserLogin CreatedByNavigation { get; set; }

    public virtual UserLogin User { get; set; }
}
