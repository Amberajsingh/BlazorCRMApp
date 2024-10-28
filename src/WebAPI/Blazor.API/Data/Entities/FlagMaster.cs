using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class FlagMaster
{
    public long Id { get; set; }

    public string FlagName { get; set; }

    public string FlagColor { get; set; }

    public bool IsActive { get; set; }

    public bool IsStatic { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public bool? IsDatetime { get; set; }

    public bool? IsOtpMobile { get; set; }

    public bool? IsOtpEmail { get; set; }

    public bool? IsHidden { get; set; }

    public int? SequenceId { get; set; }

    public bool? VisibleToAll { get; set; }

    public bool? IsAdditionalField { get; set; }

    public virtual ICollection<AdditionalFieldData> AdditionalFieldData { get; } = new List<AdditionalFieldData>();

    public virtual ICollection<Leads> Leads { get; } = new List<Leads>();

    public virtual ICollection<LeadsLog> LeadsLog { get; } = new List<LeadsLog>();

    public virtual ICollection<StatusUpdateMaster> StatusUpdateMaster { get; } = new List<StatusUpdateMaster>();
}
