using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class LeadStoreOrderDetails
{
    public Guid Id { get; set; }

    public long? UserId { get; set; }

    public Guid? CartId { get; set; }

    public DateTime? OrderDate { get; set; }

    public string OrderNumber { get; set; }

    public string UserName { get; set; }

    public virtual LeadStoreCart Cart { get; set; }
}
