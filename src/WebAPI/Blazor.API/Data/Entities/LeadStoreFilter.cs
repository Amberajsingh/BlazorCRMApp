using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class LeadStoreFilter
{
    public long Id { get; set; }

    public int? LeadTypeId { get; set; }

    public long? StateFilterId { get; set; }

    public long? ZipCodeFilterId { get; set; }

    public int? MinAge { get; set; }

    public int? MaxAge { get; set; }

    public int? LeadAge { get; set; }

    public byte? PhoneNumberPreference { get; set; }

    public string States { get; set; }

    public virtual LeadStoreLeadTypes LeadType { get; set; }
}
