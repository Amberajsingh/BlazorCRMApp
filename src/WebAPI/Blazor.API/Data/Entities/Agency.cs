using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class Agency
{
    public long Id { get; set; }

    public string Name { get; set; }

    public string Code { get; set; }

    public string Npn { get; set; }

    public string Logo { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public int? StateId { get; set; }

    public virtual ICollection<AgencyAppointment> AgencyAppointment { get; } = new List<AgencyAppointment>();

    public virtual ICollection<AgencyLicense> AgencyLicense { get; } = new List<AgencyLicense>();

    public virtual ICollection<AgencyState> AgencyState { get; } = new List<AgencyState>();

    public virtual StateMaster State { get; set; }
}
