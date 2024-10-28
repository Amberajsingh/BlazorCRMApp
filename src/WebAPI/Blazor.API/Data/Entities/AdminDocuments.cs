using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class AdminDocuments
{
    public int Id { get; set; }

    public string FileName { get; set; }

    public string FileExt { get; set; }

    public string FileType { get; set; }

    public string FileDescription { get; set; }

    public Guid AddedBy { get; set; }

    public DateTime? Date { get; set; }

    public long? UserId { get; set; }

    public bool? IsActive { get; set; }

    public virtual UserLogin AddedByNavigation { get; set; }
}
