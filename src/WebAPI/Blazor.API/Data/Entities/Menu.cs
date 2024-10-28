using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class Menu
{
    public long Id { get; set; }

    public string Name { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public string Url { get; set; }

    public long? MainMenuId { get; set; }

    public int? SequenceId { get; set; }
}
