using System;
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
}
