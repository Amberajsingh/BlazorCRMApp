using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class CityMaster
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int? StateId { get; set; }

    public virtual ICollection<Leads> Leads { get; } = new List<Leads>();

    public virtual StateMaster State { get; set; }

    public virtual ICollection<Users> Users { get; } = new List<Users>();
}
