using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class AgencyUserView
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string Code { get; set; }

    public string Npn { get; set; }

    public string Logo { get; set; }

    public string StateId { get; set; }

    public string Type { get; set; }

    public DateTime CreateDate { get; set; }

    public string ProfilePic { get; set; }
}
