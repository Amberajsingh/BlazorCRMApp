using System;

namespace Shared.Lib.Dto
{
    public class EnquiryDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
       // [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string PhoneNumber { get; set; }
        public string IpAddress { get; set; }
        public bool IsRead { get; set; }
        public DateTime ReadDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }

    public class EnquiryGridDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsRead { get; set; }
        public string CreatedDate { get; set; }
        public string ReadDate { get; set; }
    }
}
