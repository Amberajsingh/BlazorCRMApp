using System;

namespace Shared.Lib.Dto
{
    public class LeadCommentDto
    {
        public string RequestType { get; set; }
        public int Id { get; set; }
        public int LeadId { get; set; }
        public string Comment { get; set; }
        public string Description { get; set; }
        public byte? StatusType { get; set; }
        public Guid AddedBy { get; set; }
        public string AddedUserName { get; set; }
        public string AddedDate { get; set; }
        public string AddedTime { get; set; }
        public int LogType { get; set; }
    }

    public class LeadStatusDto
    {   
        public int Id { get; set; }
        public int LeadId { get; set; }
        public byte? StatusType { get; set; }
    }
}
