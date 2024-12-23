namespace Shared.Lib.Dto
{
    public class UserDto : UserUpdateDto
    {

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? Dob { get; set; }
        public string Logo { get; set; }
        public string ProfilePic { get; set; }
        public string AgencyName { get; set; }
        public string Npn { get; set; }
        public string States { get; set; }
        public string Appointment { get; set; }
        public string BodyBackGroundColor { get; set; }
        public string HeaderBackGroundColor { get; set; }
        public string NavigationBackGroundColor { get; set; }
        public string NavigationtextColor { get; set; }
        public string SubNavigationBGColor { get; set; }
        public string FooterBackGroundColor { get; set; }
        public string FooterTitleColor { get; set; }
        public string FooterTextColorH { get; set; }
        public string NavigationtextSize { get; set; }
        public string FooterTitleTextSize { get; set; }
        public string FacebookLink { get; set; }
        public string TwitterLink { get; set; }
        public string LinkedInLink { get; set; }
        public string GooglePlusLink { get; set; }
        public bool? IsHealthNavigator { get; set; }
        public long? DesignationId { get; set; }
        public string? DesignationName { get; set; }
    }

    public class UserRegistrationDto
    {
        public long? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public DateTime? Dob { get; set; }
        public string ProfilePic { get; set; }
        public int? StateId { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Role { get; set; }
        public string TimeZone { get; set; }
        public byte TimeZoneId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class UserUpdateDto
    {
        public long Id { get; set; }
        public Guid? UserLoginId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public DateTime? Dob { get; set; }
        public string ProfilePic { get; set; }
        public bool IsActive { get; set; }
        public int? StateId { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Role { get; set; }
        public string TimeZone { get; set; }
        public byte TimeZoneId { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class UserAddDto
    {
        public UserAddDto()
        {
            this.StateZipList = new List<SelectListItemtDto>();
            this.UserProducts = new List<UserProductSave1Dto>();
        }
        public UserDto BasicDetails { get; set; }
        public List<UserProductSave1Dto> UserProducts { get; set; }  
        public List<SelectListItemtDto> StateZipList { get; set; }
        public long CarrierId { get; set; }
        public string ShortUrl { get; set; }
    }

    public class UserGridDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string AgencyId { get; set; }
        public string StateId { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string ProfilePic { get; set; }       
        public string LastName { get; set; }
        public string Type { get; set; }
    }     

    public class UserProfileDto
    {
        public UserProfileDto()
        {
            this.States = new List<UserStateListDto>();
            this.Appointment = new List<UserProfileAppointmentsDto>();
            this.License = new List<UserProfileLicensesDto>();
        }
        public UserDto BasicDetails { get; set; }
        public List<UserStateListDto> States { get; set; }
        public List<UserProfileAppointmentsDto> Appointment { get; set; }
        public List<UserProfileLicensesDto> License { get; set; }
    }
    public class UserProfileLicensesDto
    {
        public string State { get; set; }
        public byte Status { get; set; }
        public string Class { get; set; }
        public string LicensesNo { get; set; }
    }

    public class UserProfileAppointmentsDto
    {
        public string State { get; set; }
        public int StateId { get; set; }
        public byte Status { get; set; }
        public string LOA { get; set; }
        public string Code { get; set; }
        public string CompanyName { get; set; }
    }

    public class UserLicensesDto
    {
        public UserLicensesDto()
        {
            this.LicensesStates = new List<UserStateLicensesDto>();
            this.States = new List<UserStateListDto>();
            this.Appointments = new List<UserProfileAppointmentsDto>();
        }
        public UserDto BasicDetails { get; set; }
        public List<UserStateLicensesDto> LicensesStates { get; set; }
        public List<UserStateListDto> States { get; set; }
        public List<UserProfileAppointmentsDto> Appointments { get; set; }
    }

    public class UserStateLicensesDto
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
        public string ActiveDate { get; set; }
        public string InActiveDate { get; set; }
        public string Class { get; set; }
        public string Number { get; set; }
        public int SaleStatusType { get; set; }

    }
    public class UserStateListDto
    {
        public string Id { get; set; }
        public long UserStateId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool Status { get; set; }
        public bool ShowAsSelected { get; set; }
    }

    public class AdminLeadGridDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Agency { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }

    }

    public class UserLeadGridDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string Status { get; set; }

    }

    public class UserOpportunityGridDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }

    }

    public class UserInfoDto
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
    }

    public class AdminNotesDto
    {
        public int Id { get; set; }
        public long UserId { get; set; }
        public string Description { get; set; }
        public string AddedDate { get; set; }

        public UserDto BasicDetails { get; set; }
    }

    public class AdminDocumentsDto
    {
        public int Id { get; set; }
        public long UserId { get; set; }
     //   public IFormFile File { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public UserDto BasicDetails { get; set; }

    }
}
