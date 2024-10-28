using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class UserTimeZones
{
    public int Id { get; set; }

    public string TimeZone { get; set; }

    public string Description { get; set; }

    public byte? DisplayOnSite { get; set; }
}
