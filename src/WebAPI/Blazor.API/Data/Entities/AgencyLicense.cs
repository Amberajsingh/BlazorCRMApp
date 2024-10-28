using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class AgencyLicense
{
    public long Id { get; set; }

    public long AgencyId { get; set; }

    public int StateId { get; set; }

    public long LicenseNo { get; set; }

    public DateTime DateIssue { get; set; }

    public DateTime? DateExpire { get; set; }

    public string Class { get; set; }

    public bool IsResidency { get; set; }

    public bool IsActive { get; set; }

    public virtual Agency Agency { get; set; }

    public virtual StateMaster State { get; set; }
}
