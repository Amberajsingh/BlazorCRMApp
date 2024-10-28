namespace Shared.Lib.Dto
{
    public class LoginResponseDto
    {
        public long UserId { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public string? Thumbprint { get; set; }
        public string Role { get; set; } = null!;
        public string? PrimarySid { get; set; }
        public string? RoleId { get; set; }
        public string? Short_Url { get; set; }
        public string? TimeZone { get; set; }
        public string? Logo { get; set; }
        public string? designationPermission { get; set; }
        public string? DateTimeFormat { get; set; }
    }
}
