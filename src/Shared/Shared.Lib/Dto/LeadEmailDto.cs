namespace Shared.Lib.Dto
{
    public class LeadEmailDto
    {
        public string RequestType { get; set; }
        public int LeadId { get; set; }
        public string NewEmail { get; set; }
        public string BodyContent { get; set; }
    }

    public class LeadFileDto
    {
        //public LeadFileDto()
        //{
        //    FilesOnOpportunity = new List<LeadFileInfoDto>();
        //}
        public int LeadId { get; set; }
       // public IFormFile File { get; set; }
        public string FileName { get; set; }

        //public List<LeadFileInfoDto> FilesOnOpportunity { get; set; }
    }
    public class LeadFileInfoDto
    {
        public int Id { get; set; }
        public int LeadId { get; set; }
        public string FileName { get; set; }
        public string FileExt { get; set; }
        public string FileType { get; set; }
        public Guid AddedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public string AddedUserName { get; set; }
        public string AddedDate { get; set; }
        public string AddedTime { get; set; }
    }

    public class LeadFileGridDto
    {
        public long Id { get; set; }
        public string FileName { get; set; }
        public string AddedDate { get; set; }

    }
}
