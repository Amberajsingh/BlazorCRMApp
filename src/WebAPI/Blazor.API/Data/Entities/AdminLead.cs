using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class AdminLead
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Mobile { get; set; }

    public int? StateId { get; set; }

    public string City { get; set; }

    public string ZipCode { get; set; }

    public string Address { get; set; }

    public string AgencyName { get; set; }

    public bool? IsUser { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string Notes { get; set; }

    public virtual ICollection<AdminLeadComment> AdminLeadComment { get; } = new List<AdminLeadComment>();

    public virtual ICollection<AdminLeadConversation> AdminLeadConversation { get; } = new List<AdminLeadConversation>();

    public virtual ICollection<AdminLeadFile> AdminLeadFile { get; } = new List<AdminLeadFile>();

    public virtual ICollection<AdminLeadNote> AdminLeadNote { get; } = new List<AdminLeadNote>();

    public virtual StateMaster State { get; set; }
}
