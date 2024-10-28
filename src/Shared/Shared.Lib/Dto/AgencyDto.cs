using System;
using System.Collections.Generic;

namespace Shared.Lib.Dto
{
    public class AgencyDto
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Npn { get; set; }
        public string Logo { get; set; }
        public bool IsActive { get; set; }
        public int? StateId { get; set; }
        public string States { get; set; }
        public string Appointment { get; set; }
    }

    public class AgencyAddDto
    {
        public AgencyAddDto()
        {
            this.States = new List<AgencyStateDto>();
            this.Appointment = new List<AgencyAppointmentDto>();
        }
        public AgencyDto BasicDetails { get; set; }
        public List<AgencyStateDto> States { get; set; }
        public List<AgencyAppointmentDto> Appointment { get; set; }
    }


    public class AgencyStateDto
    {
        public long? Id { get; set; }
        public long UserId { get; set; }
        public int StateId { get; set; }
        public byte SaleStatusType { get; set; }
        public string LicenseNo { get; set; }
        public DateTime? DateIssue { get; set; }
        public DateTime? DateExpire { get; set; }
        public string Class { get; set; }
        public byte? ResidencyStatus { get; set; }
        public byte? Status { get; set; }
    }

    public class AgencyAppointmentDto
    {
        public long? Id { get; set; }
        public long UserId { get; set; }
        public int StateId { get; set; }
        public string CompanyName { get; set; }
        public string Fein { get; set; }
        public string LineOfAuthority { get; set; }
        public string Loacode { get; set; }
        public string Cocode { get; set; }
        public byte? Status { get; set; }
        public string TerminationReason { get; set; }
        public DateTime? ReasonDate { get; set; }
        public DateTime? RenewalDate { get; set; }
    }

    public class AgencyGridDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Npn { get; set; }
        public string Logo { get; set; }
        public string IsActive { get; set; }
        public string StateId { get; set; }
    }

    public class AgencyProfileDto
    {
        public AgencyProfileDto()
        {
            this.States = new List<UserStateListDto>();
            this.Appointment = new List<UserProfileAppointmentsDto>();
            this.License = new List<UserProfileLicensesDto>();
        }
        public AgencyDto BasicDetails { get; set; }
        public List<UserStateListDto> States { get; set; }
        public List<UserProfileAppointmentsDto> Appointment { get; set; }
        public List<UserProfileLicensesDto> License { get; set; }
    }
}
