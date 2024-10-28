using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class CultureMaster
{
    public int Id { get; set; }

    public int CurrencyCodeId { get; set; }

    public int DateFormat { get; set; }

    public int TimeFormat { get; set; }

    public int Language { get; set; }

    public DateTime ModifiedDate { get; set; }

    public Guid ModifiedBy { get; set; }

    public virtual CurrencyMaster CurrencyCode { get; set; }

    public virtual UserLogin ModifiedByNavigation { get; set; }
}
