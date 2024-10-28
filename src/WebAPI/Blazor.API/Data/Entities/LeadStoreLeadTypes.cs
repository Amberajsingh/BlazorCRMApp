using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class LeadStoreLeadTypes
{
    public int Id { get; set; }

    public string LeadDescription { get; set; }

    public double Lead1To249 { get; set; }

    public double Lead250To999 { get; set; }

    public double Lead1000To4999 { get; set; }

    public double Lead5000To9999 { get; set; }

    public double Lead10000To24999 { get; set; }

    public double Lead25000Plus { get; set; }

    public double NewLeadsPrice { get; set; }

    public int? LeadTypeIdForExcel { get; set; }

    public virtual ICollection<LeadStoreFilter> LeadStoreFilter { get; } = new List<LeadStoreFilter>();
}
