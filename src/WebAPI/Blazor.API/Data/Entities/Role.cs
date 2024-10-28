using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class Role
{
    public int Id { get; set; }

    public string Name { get; set; }

    public bool? IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime ModifyDate { get; set; }

    public virtual ICollection<UserLogin> UserLogin { get; } = new List<UserLogin>();
}
