using System;

namespace Shared.Lib.Dto
{
    public class PasswordResetDto
    {
        public Guid UserId { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
        public string OldPassword { get; set; }
    }
}
