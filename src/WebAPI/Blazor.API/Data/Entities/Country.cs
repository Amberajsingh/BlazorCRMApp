using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class Country
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string CountryCode { get; set; }

    public bool? IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public virtual ICollection<State> State { get; } = new List<State>();
}
