using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class AgencyAppointment
{
    public long Id { get; set; }

    public long AgencyId { get; set; }

    public int StateId { get; set; }

    public string CompanyName { get; set; }

    public string Fein { get; set; }

    public string LineOfAuthority { get; set; }

    public string Loacode { get; set; }

    public string Cocode { get; set; }

    public byte? Status { get; set; }

    public string TerminationReason { get; set; }

    public DateTime? ReasonDate { get; set; }

    public DateTime? RenewalDate { get; set; }

    public virtual Agency Agency { get; set; }

    public virtual StateMaster State { get; set; }
}
