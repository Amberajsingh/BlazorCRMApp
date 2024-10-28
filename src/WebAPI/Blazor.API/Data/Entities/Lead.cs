using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class Lead
{
    public int Id { get; set; }

    public long? UserId { get; set; }

    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string MobileNumber { get; set; }

    public string Address1 { get; set; }

    public string Address2 { get; set; }

    public int? StateId { get; set; }

    public string City { get; set; }

    public string ZipCode { get; set; }

    public byte? GenderType { get; set; }

    public string Height { get; set; }

    public string Weight { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string Source { get; set; }

    public byte? Status { get; set; }

    public string Notes { get; set; }

    public string MotherMaidenName { get; set; }

    public string DriverLicenseNumber { get; set; }

    public string Occupation { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public byte LeadType { get; set; }

    public bool? IsActive { get; set; }

    public byte? OpportunityStatus { get; set; }

    public string CompanyName { get; set; }

    public string MainContactName { get; set; }

    public int? NumberOfEmployess { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public virtual ICollection<AlternateContactDetail> AlternateContactDetail { get; } = new List<AlternateContactDetail>();

    public virtual ICollection<LeadComment> LeadComment { get; } = new List<LeadComment>();

    public virtual ICollection<LeadConversation> LeadConversation { get; } = new List<LeadConversation>();

    public virtual ICollection<LeadFile> LeadFile { get; } = new List<LeadFile>();

    public virtual ICollection<LeadLog> LeadLog { get; } = new List<LeadLog>();

    public virtual ICollection<LeadNote> LeadNote { get; } = new List<LeadNote>();

    public virtual State State { get; set; }

    public virtual Users User { get; set; }
}
