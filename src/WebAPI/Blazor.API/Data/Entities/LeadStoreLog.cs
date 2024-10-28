using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class LeadStoreLog
{
    public long Id { get; set; }

    public string ExcelPath { get; set; }

    public string LogPath { get; set; }

    public DateTime? Date { get; set; }

    public Guid AddedBy { get; set; }

    public string FileName { get; set; }

    public virtual UserLogin AddedByNavigation { get; set; }

    public virtual ICollection<Leads> Leads { get; } = new List<Leads>();
}
