using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class AdditionalFieldData
{
    public int Id { get; set; }

    public long FlagId { get; set; }

    public string FieldName { get; set; }

    public int FieldType { get; set; }

    public bool? Required { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdateOn { get; set; }

    public bool? IsActive { get; set; }

    public virtual FlagMaster Flag { get; set; }
}
