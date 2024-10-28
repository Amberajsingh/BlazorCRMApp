using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class LeadStoreCart
{
    public Guid Id { get; set; }

    public long? UserId { get; set; }

    public int? NumberOfLeads { get; set; }

    public byte? IsLeadUnder20Days { get; set; }

    public int? LeadTypeId { get; set; }

    public double? PerLeadPrice { get; set; }

    public double? TotalPrice { get; set; }

    public double? Tax { get; set; }

    public double? Discount { get; set; }

    public double? GrantTotal { get; set; }

    public virtual ICollection<LeadStoreOrderDetails> LeadStoreOrderDetails { get; } = new List<LeadStoreOrderDetails>();
}
