using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class DesignationMaster
{
    public long Id { get; set; }

    public string Name { get; set; }

    public string Colour { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<DesignationPermission> DesignationPermission { get; } = new List<DesignationPermission>();

    public virtual ICollection<Users> Users { get; } = new List<Users>();
}
