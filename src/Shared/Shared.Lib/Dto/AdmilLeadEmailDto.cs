namespace Shared.Lib.Dto
{
    public class AdminLeadEmailDto
    {
        public int AdminLeadId { get; set; }
        public string NewEmail { get; set; }
        public string BodyContent { get; set; }
    }

    public class AdminLeadFileDto
    {
        public int AdminLeadId { get; set; }
       // public IFormFile File { get; set; }
        public string FileName { get; set; }
    }
    public class AdminLeadFileInfoDto
    {
        public int AdminLeadId { get; set; }
        public string FileName { get; set; }
        public string FileExt { get; set; }
        public string FileType { get; set; }
        public Guid AddedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }

    public class AdminLeadFileGridDto
    {
        public long Id { get; set; }
        public string FileName { get; set; }
        public string AddedDate { get; set; }
    }
}