using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class MenuItem
{
    public int Id { get; set; }

    public string MenuName { get; set; }

    public string SubMenuName { get; set; }

    public string MenuIcon { get; set; }

    public string MenuUrl { get; set; }

    public bool? IsActvie { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string SubMenuIcon { get; set; }

    public double? MenuOrder { get; set; }
}
