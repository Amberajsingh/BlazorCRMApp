using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class DesignationPermission
{
    public int Id { get; set; }

    public int DesignationPermissionId { get; set; }

    public long DesignationId { get; set; }

    public DateTime? CreationOn { get; set; }

    public int? CreatorBy { get; set; }

    public virtual DesignationMaster Designation { get; set; }
}
