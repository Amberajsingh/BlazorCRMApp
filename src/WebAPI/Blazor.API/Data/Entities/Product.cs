using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class Product
{
    public long Id { get; set; }

    public long CarrierId { get; set; }

    public string Name { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public long? MenuId { get; set; }

    public virtual Carrier Carrier { get; set; }

    public virtual ICollection<Plan> Plan { get; } = new List<Plan>();

    public virtual ICollection<UserProduct> UserProduct { get; } = new List<UserProduct>();
}
