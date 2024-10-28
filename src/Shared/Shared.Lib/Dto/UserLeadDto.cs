using System;

namespace Shared.Lib.Dto
{
    public class UserLeadDto
    {
        public UserLeadDto()
        {
            leadCommentDto = new LeadCommentDto();
        }

        public long? Id { get; set; }
        public long? UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int? StateId { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public byte? GenderType { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string DateOfBirth { get; set; }
        public string Source { get; set; }
        public byte? Status { get; set; }
        public byte LeadType { get; set; }
        public byte? OpportunityStatus { get; set; }
        public bool IsActive { get; set; }
        public string Notes { get; set; }
        public string MotherMaidenName { get; set; }
        public string DriverLicenseNumber { get; set; }
        public string Occupation { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public LeadCommentDto leadCommentDto { get; set; }

    }

    public class UserLeadAddDto
    {
        public UserLeadDto BasicDetails { get; set; }
    }
}
