using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class AdminLeadFile
{
    public int Id { get; set; }

    public int AdminLeadId { get; set; }

    public string FileName { get; set; }

    public string FileExt { get; set; }

    public string FileType { get; set; }

    public Guid AddedBy { get; set; }

    public DateTime? Date { get; set; }

    public virtual UserLogin AddedByNavigation { get; set; }

    public virtual AdminLead AdminLead { get; set; }
}
