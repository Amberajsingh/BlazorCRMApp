using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class AgencyState
{
    public long Id { get; set; }

    public long AgencyId { get; set; }

    public int StateId { get; set; }

    public byte SaleStatusType { get; set; }

    public string LicenseNo { get; set; }

    public DateTime? DateIssue { get; set; }

    public DateTime? DateExpire { get; set; }

    public string Class { get; set; }

    public byte? ResidencyStatus { get; set; }

    public byte? Status { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual Agency Agency { get; set; }

    public virtual StateMaster State { get; set; }
}
