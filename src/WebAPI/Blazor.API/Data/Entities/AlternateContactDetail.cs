using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class AlternateContactDetail
{
    public long Id { get; set; }

    public string ContactNumber { get; set; }

    public int LeadId { get; set; }

    public string Email { get; set; }

    public DateTime? CreateDate { get; set; }
}
