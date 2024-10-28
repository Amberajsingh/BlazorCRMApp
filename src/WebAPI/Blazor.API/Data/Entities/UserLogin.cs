using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class UserLogin
{
    public Guid Id { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public string PasswordSalt { get; set; }

    public int RoleType { get; set; }

    public bool IsVerifiedEmail { get; set; }

    public bool IsVerified { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime ModifyDate { get; set; }

    public string ForgetPasswordLink { get; set; }

    public DateTime? ForgetPasswordExpirationDate { get; set; }

    public DateTime? LastLoginDate { get; set; }

    public DateTime? LastPasswordChangeDate { get; set; }

    public virtual ICollection<AdminDocuments> AdminDocuments { get; } = new List<AdminDocuments>();

    public virtual ICollection<AdminLeadComment> AdminLeadComment { get; } = new List<AdminLeadComment>();

    public virtual ICollection<AdminLeadConversation> AdminLeadConversation { get; } = new List<AdminLeadConversation>();

    public virtual ICollection<AdminLeadFile> AdminLeadFile { get; } = new List<AdminLeadFile>();

    public virtual ICollection<AdminLeadNote> AdminLeadNote { get; } = new List<AdminLeadNote>();

    public virtual ICollection<CultureMaster> CultureMaster { get; } = new List<CultureMaster>();

    public virtual ICollection<LeadComment> LeadComment { get; } = new List<LeadComment>();

    public virtual ICollection<LeadConversation> LeadConversation { get; } = new List<LeadConversation>();

    public virtual ICollection<LeadEvent> LeadEventCreatedByNavigation { get; } = new List<LeadEvent>();

    public virtual ICollection<LeadEvent> LeadEventUser { get; } = new List<LeadEvent>();

    public virtual ICollection<LeadFile> LeadFile { get; } = new List<LeadFile>();

    public virtual ICollection<LeadNote> LeadNote { get; } = new List<LeadNote>();

    public virtual ICollection<LeadStoreLog> LeadStoreLog { get; } = new List<LeadStoreLog>();

    public virtual ICollection<Leads> Leads { get; } = new List<Leads>();

    public virtual ICollection<LeadsLog> LeadsLogCreatedByNavigation { get; } = new List<LeadsLog>();

    public virtual ICollection<LeadsLog> LeadsLogModifiedByNavigation { get; } = new List<LeadsLog>();

    public virtual Role RoleTypeNavigation { get; set; }

    public virtual ICollection<Users> UsersParent { get; } = new List<Users>();

    public virtual ICollection<Users> UsersUserLogin { get; } = new List<Users>();
}
