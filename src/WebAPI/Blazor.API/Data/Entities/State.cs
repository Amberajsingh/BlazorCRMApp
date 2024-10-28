using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class State
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string StateCode { get; set; }

    public int? CountryId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public virtual ICollection<AdminLead> AdminLead { get; } = new List<AdminLead>();

    public virtual ICollection<Agency> Agency { get; } = new List<Agency>();

    public virtual ICollection<AgencyAppointment> AgencyAppointment { get; } = new List<AgencyAppointment>();

    public virtual ICollection<AgencyLicense> AgencyLicense { get; } = new List<AgencyLicense>();

    public virtual ICollection<AgencyState> AgencyState { get; } = new List<AgencyState>();

    public virtual Country Country { get; set; }

    public virtual ICollection<Lead> Lead { get; } = new List<Lead>();

    public virtual ICollection<LeadStoreLeads> LeadStoreLeads { get; } = new List<LeadStoreLeads>();

    public virtual ICollection<StatePlan> StatePlan { get; } = new List<StatePlan>();

    public virtual ICollection<UserOpportunity> UserOpportunity { get; } = new List<UserOpportunity>();

    public virtual ICollection<Users> Users { get; } = new List<Users>();
}
