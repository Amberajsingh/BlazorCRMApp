using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class CountryMaster
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string CountryCode { get; set; }

    public virtual ICollection<Leads> Leads { get; } = new List<Leads>();

    public virtual ICollection<StateMaster> StateMaster { get; } = new List<StateMaster>();

    public virtual ICollection<Users> Users { get; } = new List<Users>();
}
