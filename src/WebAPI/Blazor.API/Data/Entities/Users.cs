using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class Users
{
    public long Id { get; set; }

    public Guid UserLoginId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Mobile { get; set; } = null!;

    public DateTime? Dob { get; set; }

    public string? Phone { get; set; }

    public string? ShortUrl { get; set; }

    public string? Logo { get; set; }

    public byte? TimeZoneId { get; set; }

    public int? CountryId { get; set; }

    public int? StateId { get; set; }

    public int? CityId { get; set; }

    public string? ZipCode { get; set; }

    public string? Address { get; set; }

    public long? DesignationId { get; set; }

    public string? Colour { get; set; }

    public Guid? ParentId { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public bool IsDeleted { get; set; }=false;

    public string? BodyBackGroundColor { get; set; } 

    public string? HeaderBackGroundColor { get; set; }

    public string? NavigationBackGroundColor { get; set; } 

    public string? NavigationtextColor { get; set; } 

    public string? SubNavigationBgcolor { get; set; } 

    public string? FooterBackGroundColor { get; set; }

    public string? FooterTitleColor { get; set; } 

    public string? FooterTextColorH { get; set; }

    public string? NavigationtextSize { get; set; } 

    public string? FooterTitleTextSize { get; set; }

    public string? FacebookLink { get; set; } 

    public string? TwitterLink { get; set; }

    public string? LinkedInLink { get; set; }

    public string? GooglePlusLink { get; set; }

    public string? ProfilePic { get; set; }

    public long? LeadStoreFilterId { get; set; } 

    public byte? IsHealthNavigator { get; set; }

    public virtual ICollection<AdminCalendarUsers> AdminCalendarUsers { get; } = new List<AdminCalendarUsers>();

    public virtual ICollection<AdminNotes> AdminNotes { get; } = new List<AdminNotes>();

    public virtual CityMaster City { get; set; }

    public virtual CountryMaster Country { get; set; }

    public virtual DesignationMaster Designation { get; set; }

    public virtual UserLogin Parent { get; set; }

    public virtual StateMaster State { get; set; }

    public virtual ICollection<UserCalendar> UserCalendar { get; } = new List<UserCalendar>();

    public virtual ICollection<UserCarrier> UserCarrier { get; } = new List<UserCarrier>();

    public virtual UserLogin UserLogin { get; set; }

    public virtual ICollection<UserOpportunity> UserOpportunity { get; } = new List<UserOpportunity>();

    public virtual ICollection<UserProduct> UserProduct { get; } = new List<UserProduct>();
}
