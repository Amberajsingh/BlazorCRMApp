using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shared.Lib.Dto
{
    public class LeadStoreLeadsDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string WorkPhone { get; set; }
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
        public byte IsSold { get; set; }
        public bool? IsActive { get; set; }
        public int? Age { get; set; }
        public int? LeadAge { get; set; }
        public long UserId { get; set; }
        public int LeadType { get; set; }
        public int Count { get; set; }
        public string OrderNumber { get; set; }

    }

    public class LeadStoreGridDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string Status { get; set; }
        public string isSold { get; set; }
        public int LeadAge { get; set; }

        public string UserName { get; set; }

    }

    public class LeadStoreOrderOverviewDto
    {
        public LeadStoreOrderOverviewDto()
        {
            List<LeadStoreGridDto> Leads = new List<LeadStoreGridDto>();
            LeadStoreCartDto Cart = new LeadStoreCartDto();
        }

        public Guid Id { get; set; }
        public Guid CartID { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public List<LeadStoreGridDto> Leads { get; set; }
        public LeadStoreCartDto Cart { get; set; }
    }

    public class ImportLeadStoreDto
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfbirth { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int? StateId { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string WorkPhone { get; set; }
        public string Email { get; set; }
        public string MotherMaidenName { get; set; }
        public string LicenseNumber { get; set; }
        public string Occupation { get; set; }
        public string Notes { get; set; }
        public int LeadTypeId { get; set; }
        public string LeadType { get; set; }
        public string BulkNote { get; set; }
        public bool IsValid { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class LeadStoreLogsDto
    {
        public long Id { get; set; }
        public string FileName { get; set; }
        public string LogType { get; set; }
        public string ExcelFilePath { get; set; }
        public string LogFilePath { get; set; }
        public string Date { get; set; }
        public Guid AddedBy { get; set; }
        public string AddedUserName { get; set; }
        public bool Import { get; set; }
    }

    public class LeadStoreLeadTypeDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Lead Type ID is required.")]
        public int LeadTypeId { get; set; }
        public byte LeadType { get; set; }
        [Required(ErrorMessage = "Lead Type Description is required.")]
        public string LeadDescription { get; set; }
        [Required(ErrorMessage = "Price is required.")]
        public double Lead1To249 { get; set; }
        [Required(ErrorMessage = "Price is required.")]
        public double Lead250To999 { get; set; }
        [Required(ErrorMessage = "Price is required.")]
        public double Lead1000To4999 { get; set; }
        [Required(ErrorMessage = "Price is required.")]
        public double Lead5000To9999 { get; set; }
        [Required(ErrorMessage = "Price is required.")]
        public double Lead10000To24999 { get; set; }
        [Required(ErrorMessage = "Price is required.")]
        public double Lead25000Plus { get; set; }
        [Required(ErrorMessage = "Price is required.")]
        public double NewLeadsPrice { get; set; }
        [Required(ErrorMessage = "Price is required.")]
        public byte IsSelectedPrice { get; set; }
        public string PriceType { get; set; }
    }
       
    public class LeadStoreFilterDto
    {
        public long Id { get; set; }
        public int LeadType { get; set; }
        public string LeadTypeDescription { get; set; }
        public long StateCode { get; set; }
        public string States { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public int LeadAge { get; set; }
        public string LeadAgeDescription { get; set; }
        public long ZipCodeId { get; set; }
        public byte PhoneNumberPreference { get; set; }
        public string ZipCodes { get; set; }
    }

    public class BuyLeadsDto
    {
        public BuyLeadsDto()
        {
            List<LeadStoreLeadTypeDto> Price = new List<LeadStoreLeadTypeDto>();
            LeadStoreOrderOverviewDto Order = new LeadStoreOrderOverviewDto();
            LeadStoreCartDto Cart = new LeadStoreCartDto();
            LeadStoreFilterDto Filters = new LeadStoreFilterDto();
        }
        public List<LeadStoreLeadTypeDto> Price { get; set; }
        public LeadStoreFilterDto Filters { get; set; }
        public LeadStoreOrderOverviewDto Order { get; set; }
        public LeadStoreLeadTypeDto LeadPrice { get; set; }
        public LeadStoreCartDto Cart { get; set; }
    }

    public class LeadStoreOverview
    {
        public int LeadsPurchasedToday { get; set; }
        public int TotalLeadsPurchased { get; set; }
        public float LeadsPurchasedAmount { get; set; }
    }

  
    public class LeadStoreCartDto
    {
        public Guid Id { get; set; }
        public long UserId { get; set; }
        public int AvailableLeads { get; set; }
        public int LeadTypeId { get; set; }
        public int LeadsCount { get; set; }
        public bool IsLeadUnder20Days { get; set; }
        public string LeadType { get; set; }
        public string LeadsTitle { get; set; }
        public double PricePerlead { get; set; }
        public double TotalPrice { get; set; }
        public float Tax { get; set; }
        public float Discount { get; set; }
        public double GrandTotal { get; set; }

    }
}