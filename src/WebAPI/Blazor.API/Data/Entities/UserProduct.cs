using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class UserProduct
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public long CarrierId { get; set; }

    public long ProductId { get; set; }

    public bool IsActive { get; set; }

    public virtual Carrier Carrier { get; set; }

    public virtual Product Product { get; set; }

    public virtual Users User { get; set; }
}
