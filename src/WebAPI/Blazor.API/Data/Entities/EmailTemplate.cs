using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class EmailTemplate
{
    public short Id { get; set; }

    public string Subject { get; set; }

    public string Content { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }
}
