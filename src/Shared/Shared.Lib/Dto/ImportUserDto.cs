using System;

namespace Shared.Lib.Dto
{
    public class ImportUserDto
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? Dob { get; set; }
        public long AgencyId { get; set; }
        public string AgencyName { get; set; }
        public string Npn { get; set; }
        public string Mobile { get; set; }
        public byte Status { get; set; }
        public string StatusName { get; set; }
        public string Address { get; set; }
        public int? StateId { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string SSN { get; set; }
        public string UserStateJson { get; set; }
        public string AppointmentJson { get; set; }
        public string BulkNote { get; set; }
        public bool IsValid { get; set; }
    }

    public class UserMailDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Pasword { get; set; }
    }


    public class ImportLeadDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public int? StateId { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string BulkNote { get; set; }
        public bool IsValid { get; set; }
        public string? Agency { get; set; }
        public string? Notes { get; set; }
    }

    public class ImportUserLeadDto
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName{ get; set; }
        public string Gender{ get; set; }
        public DateTime? DateOfbirth { get; set; }
        public string Height { get; set; }
        public string Weight{ get; set; }
        public string Address1{ get; set; }
        public string Address2{ get; set; }
        public int? StateId { get; set; }
        public string State { get; set; }
        public string ZipCode{ get; set; }
        public string City{ get; set; }
        public string Phone{ get; set; }
        public string Mobile{ get; set; }
        public string Email{ get; set; }
        public string MotherMaidenName { get; set; }
        public string LicenseNumber{ get; set; }
        public string Occupation{ get; set; }
        public string Notes{ get; set; }
        public string BulkNote { get; set; }
        public bool IsValid { get; set; }
    }


    public class ImportOpportunityDto
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
        public string Email { get; set; }
        public string MotherMaidenName { get; set; }
        public string LicenseNumber { get; set; }
        public string Occupation { get; set; }
        public string Notes { get; set; }
        public string BulkNote { get; set; }
        public bool IsValid { get; set; }
    }
}
