using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class UserOpportunity
{
    public int Id { get; set; }

    public long UserId { get; set; }

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

    public byte? OpportunityStatus { get; set; }

    public byte? LeadStatus { get; set; }

    public string Source { get; set; }

    public string Notes { get; set; }

    public string MotherMaidenName { get; set; }

    public string DriverLicenseNumber { get; set; }

    public string Occupation { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public virtual StateMaster State { get; set; }

    public virtual Users User { get; set; }
}
