using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class Carrier
{
    public long Id { get; set; }

    public string Name { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public string Logo { get; set; }

    public bool IsAca { get; set; }

    public bool? ShowInAdminGraph { get; set; }

    public int? GraphSequenceNumber { get; set; }

    public virtual ICollection<Product> Product { get; } = new List<Product>();

    public virtual ICollection<UserCarrier> UserCarrier { get; } = new List<UserCarrier>();

    public virtual ICollection<UserProduct> UserProduct { get; } = new List<UserProduct>();
}
