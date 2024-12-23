using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Shared.Lib.Dto
{
    public class UserLoginDto
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string ProfileImage { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public int RoleType { get; set; }
        public bool IsVerified { get; set; }
        public bool IsVerifiedEmail { get; set; }
        public bool IsActive { get; set; }
        public long UserId { get; set; }
        public string DateTimeFormat { get; set; }


        public long? DesignationId { get; set; }
        public Guid? ParentId { get; set; }
    }


    public class LoginDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public bool IsLogin { get; set; } = false;
        public bool RememberMe { get; set; } = false;
    }

    public class PasswordResetRequestModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }

    public class ResetPasswordModel
    {
        public string Token { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "'New Password' is required")]
        [DisplayName("New Password")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,15}$", ErrorMessage = "New Password must be between 8 and 15 characters and contain one uppercase letter, one lowercase letter, one digit and one special character.")]
        public string NewPassword { get; set; }

        [Required]
        [Compare("NewPassword")]
        public string ConfirmPassword { get; set; }
    }
}
