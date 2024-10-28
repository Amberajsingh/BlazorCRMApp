using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class CurrencyMaster
{
    public int Id { get; set; }

    public string CurrencyCode { get; set; }

    public string CurrencyDisplayName { get; set; }

    public virtual ICollection<CultureMaster> CultureMaster { get; } = new List<CultureMaster>();
}
