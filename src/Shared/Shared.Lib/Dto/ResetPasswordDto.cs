using System.ComponentModel;

namespace Shared.Lib.Dto
{
    public class ChangePasswordDto
    {
        [DisplayName("Old Password")]
        public string OldPassword { get; set; }

        [DisplayName("New Password")]
        public string Password { get; set; }

        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }
        public bool IsNewAccount { get; set; }
        public string Email { get; set; }
    }
}
