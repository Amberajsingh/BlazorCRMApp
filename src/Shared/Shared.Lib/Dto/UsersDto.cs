using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Shared.Lib.Dto
{
    public class UsersDto
    {
        public long? Id { get; set; }
        public Guid? UserLoginId { get; set; }

        [Required(ErrorMessage = "'First Name' is required")]
        [DisplayName("First Name")]
        public string FirstName { get; set; } = null!;

        [DisplayName("Last Name")]
        public string? LastName { get; set; }


        [DisplayName("Email Address")]
        [Required(ErrorMessage = "'Email Address' is required")]
        [EmailAddress(ErrorMessage = "Please enter valid email.")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please enter valid email.")]

        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "'Mobile No' is required")]
        [DisplayName("Mobile No")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Mobile { get; set; } = null!;

        [DisplayName("Date Of Birth")]

        public DateTime? Dob { get; set; }

        public string? ShortUrl { get; set; }

        [Required(ErrorMessage = "'Country' is required")]
        [DisplayName("Country")]
        public int CountryId { get; set; }

        [Required(ErrorMessage = "'State' is required")]
        [DisplayName("State")]
        public int StateId { get; set; }

        [Required(ErrorMessage = "'City' is required")]
        [DisplayName("City")]
        public int CityId { get; set; }

        [Required(ErrorMessage = "'ZipCode' is required")]
        [DisplayName("ZipCode")]
        public string ZipCode { get; set; } = null!;

        [Required(ErrorMessage = "Address is required")]
        [DisplayName("Address")]
        public string Address { get; set; } = null!;

        public string BodyBackGroundColor { get; set; } = "white";

        [DisplayName("Time Zone")]
        public byte? TimeZoneId { get; set; }
        //[Required(ErrorMessage = "'Designation' is required")]
        public long? DesignationId { get; set; }

        //[Required(ErrorMessage = "'Colour' is required")]
        public string? Colour { get; set; }

        //[Required(ErrorMessage = "'Parent' is required")]
        public Guid? ParentId { get; set; }

        [Required(ErrorMessage = "'Password' is required")]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,15}$", ErrorMessage = "Password must be between 8 and 15 characters and contain one uppercase letter, one lowercase letter, one digit and one special character.")]

        public string Password { get; set; } = null!;

        [DisplayName("Active")]
        public bool IsActive { get; set; } = false;

        [DisplayName("Verified")]
        public bool IsVerified { get; set; } = false;

        public bool FormType { get; set; } = false;
    }

    public class Root
    {
        public Guid id { get; set; }
        public string title { get; set; }
        public List<Sub> subs { get; set; }
    }

    public class Sub
    {
        public Guid id { get; set; }
        public string title { get; set; }
        public List<Sub> subs { get; set; }
    }


}
