using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class StateMaster
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int? CountryId { get; set; }

    public virtual ICollection<AdminLead> AdminLead { get; } = new List<AdminLead>();

    public virtual ICollection<Agency> Agency { get; } = new List<Agency>();

    public virtual ICollection<AgencyAppointment> AgencyAppointment { get; } = new List<AgencyAppointment>();

    public virtual ICollection<AgencyLicense> AgencyLicense { get; } = new List<AgencyLicense>();

    public virtual ICollection<AgencyState> AgencyState { get; } = new List<AgencyState>();

    public virtual ICollection<CityMaster> CityMaster { get; } = new List<CityMaster>();

    public virtual CountryMaster Country { get; set; }

    public virtual ICollection<Leads> Leads { get; } = new List<Leads>();

    public virtual ICollection<StatePlan> StatePlan { get; } = new List<StatePlan>();

    public virtual ICollection<UserOpportunity> UserOpportunity { get; } = new List<UserOpportunity>();

    public virtual ICollection<Users> Users { get; } = new List<Users>();
}
