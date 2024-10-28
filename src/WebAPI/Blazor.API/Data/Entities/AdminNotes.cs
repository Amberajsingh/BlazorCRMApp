using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class AdminNotes
{
    public int Id { get; set; }

    public long UserId { get; set; }

    public string Description { get; set; }

    public DateTime? AddedDate { get; set; }

    public virtual Users User { get; set; }
}
