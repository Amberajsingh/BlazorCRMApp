namespace Shared.Lib.Dto
{
    public class HNHomeDto
    {
        public string Name { get; set; }
        public decimal Count { get; set; }
    }
    public class HealthNavigatorLeadDto
    {
        public HealthNavigatorLeadDto()
        {
            leadCommentDto = new LeadCommentDto();
            List<AlternateContactNumberDto> AlternateContact = new List<AlternateContactNumberDto>();

        }

        public long? Id { get; set; }
        public long? UserId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int? StateId { get; set; }
        public int TimeZoneId { get; set; }
        public string TimeZone { get; set; }
        public int? NumberOfEmployees { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public byte? Status { get; set; }
        public byte LeadType { get; set; }
        public byte? OpportunityStatus { get; set; }
        public bool IsActive { get; set; }
        public string Notes { get; set; }
        public string EffectiveDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public LeadCommentDto leadCommentDto { get; set; }
        public List<AlternateContactNumberDto> AlternateContact { get; set; }

    }

    public class HealthNavigatorDashboardDto
    {
        public HealthNavigatorDashboardDto()
        {
            this.RecentOpportunities = new List<HNLeadGridDto>();
        }
        public int TotalLead { get; set; }
        public int TotalOpportunity { get; set; }
        public int TotalOpportunityEmployees { get; set; }
        public int TotalActiveEmployees { get; set; }
        public List<HNLeadGridDto> RecentOpportunities { get; set; }
    }

    public class AlternateContactNumberDto
    {
        public long Id { get; set; }
        public string ContactNumber { get; set; }
        public int LeadId { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
    }

    public class HealthNavigatorLeadAddDto
    {
        public HealthNavigatorLeadDto BasicDetails { get; set; }
    }

    public class HNLeadGridDto
    {
        public long Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string State { get; set; }
        public string Status { get; set; }
        public int Employees { get; set; }
        public string EffectiveDate { get; set; }
    }

    public class ImportHealthNavigatorLeadDto
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public int NumberOfEmployees { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int? StateId { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public string BulkNote { get; set; }
        public bool IsValid { get; set; }
    }

    public class DocumentsDto
    {
        public int LeadId { get; set; }
        //public IFormFile File { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }

    }

    public class AdminDocumentsInfoDto
    {
        public int Id { get; set; }
        public long UserId { get; set; }
        public string FileName { get; set; }
        public string FileExt { get; set; }
        public string FileType { get; set; }
        public Guid AddedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public string AddedUserName { get; set; }
        public string AddedDate { get; set; }
        public string AddedTime { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
    }

  
}
