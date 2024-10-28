using System;
using System.Collections.Generic;

namespace Shared.Lib.Dto
{
    public class LeadDto
    {
        public long? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int? StateId { get; set; }
        public string? Agency { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
    }

    public class LeadMailDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class LeadAddDto
    {
        
        public LeadDto BasicDetails { get; set; }

    }

    public class LeadProductDto
    {
        public long Id { get; set; }
        public long LeadId { get; set; }
        public long OpportunityId { get; set; }
        public string ProductType { get; set; }
        public string ProspectName { get; set; }
        public string PlanName { get; set; }
        public string Network { get; set; }
        public string CarrierDescription { get; set; }
        public string Broucher { get; set; }
        public string Deductible { get; set; }
        public string CoInsurance { get; set; }
        public string StateCode { get; set; }
        public string ZipCode { get; set; }
        public string Rate { get; set; }
        public string Status { get; set; }
        public string PaymentType { get; set; }
        public string CreatedDate { get; set; }
        public string PaymentDate { get; set; }
        public string UpdatedDate { get; set; }
        public bool IsPlanComplete { get; set; }
    }

    public class LeadAdditionalPeopleDto
    {
        public LeadAdditionalPeopleDto()
        {
            List<LeadChildDetails> childDetails = new List<LeadChildDetails>();
        }
        public long Id { get; set; }
        public long LeadId { get; set; }
        public bool IsSpouse { get; set; }
        public int SpouseAge { get; set; }
        public DateTime SpouseBirthDate { get; set; }
        public string SpouseGender { get; set; }
        public int RelationshipType { get; set; }
        public bool SpouseIsSmoker { get; set; }
        public DateTime SpouseDateLastSmoked { get; set; }
        public bool SpouseHasPriorCoverage { get; set; }
        public List<LeadChildDetails> childDetails { get; set; }

    }
    public class LeadChildDetails
    {
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public int Gender { get; set; }
        public int RelationshipType { get; set; }
        public bool IsSmoker { get; set; }
        public DateTime DateLastSmoked { get; set; }
        public bool HasPriorCoverage { get; set; }
    }


}
