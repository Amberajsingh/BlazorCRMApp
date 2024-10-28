namespace Shared.Lib.Dto
{
    public class EmailTemplateDto
    {
        public short Id { get; set; }
        public string EmailSubject { get; set; }
        public short EmailTypeId { get; set; }        
        public string Content { get; set; }
        public bool IsActive { get; set; }
    }


    public class EmailTemplateGridDto
    {
        public long Id { get; set; }
        public string Subject { get; set; }
        public string Type { get; set; }
        public string CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
