using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class AdminCalendarUsers
{
    public long Id { get; set; }

    public long AdminCalendarId { get; set; }

    public long UserId { get; set; }

    public virtual AdminCalendar AdminCalendar { get; set; }

    public virtual Users User { get; set; }
}
