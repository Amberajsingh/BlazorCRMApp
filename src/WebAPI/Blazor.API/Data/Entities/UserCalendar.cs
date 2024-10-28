using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class UserCalendar
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string Title { get; set; }

    public DateTime? Date { get; set; }

    public string Description { get; set; }

    public string Location { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsActive { get; set; }

    public virtual Users User { get; set; }
}
