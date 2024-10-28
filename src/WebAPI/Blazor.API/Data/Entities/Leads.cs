using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class Leads
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string MobileNumber { get; set; }

    public string Address { get; set; }

    public int? CountryId { get; set; }

    public int? StateId { get; set; }

    public int? CityId { get; set; }

    public string ZipCode { get; set; }

    public byte? GenderType { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string Notes { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public byte IsSold { get; set; }

    public bool IsActive { get; set; }

    public long? LogId { get; set; }

    public Guid? LeadsCartId { get; set; }

    public string OrderNumber { get; set; }

    public Guid? UserId { get; set; }

    public long LeadSourceId { get; set; }

    public long FlagId { get; set; }

    public long? PriorityId { get; set; }

    public string Description { get; set; }

    public bool IsDeleted { get; set; }

    public string MobileOtp { get; set; }

    public string EmailOtp { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string TempEmailOtp { get; set; }

    public DateTime? EmailOtptime { get; set; }

    public string TempMobileOtp { get; set; }

    public DateTime? MobileOtptime { get; set; }

    public DateTime? LeadAssignedDate { get; set; }

    public long? LeadQualityId { get; set; }

    public long? LeadCategoryId { get; set; }

    public int? Crmtype { get; set; }

    public int? LeadParentId { get; set; }

    public virtual CityMaster City { get; set; }

    public virtual CountryMaster Country { get; set; }

    public virtual FlagMaster Flag { get; set; }

    public virtual LeadCategoryMaster LeadCategory { get; set; }

    public virtual ICollection<LeadNote> LeadNote { get; } = new List<LeadNote>();

    public virtual LeadQualityMaster LeadQuality { get; set; }

    public virtual LeadSourceMaster LeadSource { get; set; }

    public virtual ICollection<LeadsLog> LeadsLog { get; } = new List<LeadsLog>();

    public virtual LeadStoreLog Log { get; set; }

    public virtual PriorityMaster Priority { get; set; }

    public virtual StateMaster State { get; set; }

    public virtual ICollection<StatusUpdateMaster> StatusUpdateMaster { get; } = new List<StatusUpdateMaster>();

    public virtual UserLogin User { get; set; }
}
