using System.Collections.Generic;

namespace Shared.Lib.Dto
{
    public class UserCalendarDto
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Date { get; set; }
        public string CurrentDate { get; set; }
        public string Location { get; set; }

        public bool IsDelete { get; set; } = false;
        public string title { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public string startStr { get; set; }
        public string endStr { get; set; }
        public string groupId { get; set; }
        public string backgroundColor { get; set; }
        public string textColor { get; set; }
        public string description { get; set; }
        public string borderColor { get; set; }
        public bool editable { get; set; }
        public string[] classNames { get; set; }

        public string rendering { get; set; }
        public string color { get; set; }

        public string constraint { get; set; }

        public bool overlap { get; set; }
        public bool IsAdminEvent { get; set; }

    }

    public class AdminCalendarUserDto
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; }
    }
    public class AdminCalendarDto
    {
        public AdminCalendarDto()
        {
            List<long> UserIds = new List<long>();
        }

        public long Id { get; set; }
        public string Date { get; set; }
        public string CurrentDate { get; set; }
        public string Location { get; set; }
        public bool IsDelete { get; set; } = false;
        public string title { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public string startStr { get; set; }
        public string endStr { get; set; }
        public string groupId { get; set; }
        public string backgroundColor { get; set; }
        public string textColor { get; set; }
        public string description { get; set; }
        public string borderColor { get; set; }
        public bool editable { get; set; }
        public string[] classNames { get; set; }

        public string rendering { get; set; }
        public string color { get; set; }

        public string constraint { get; set; }

        public bool overlap { get; set; }
        public List<long> UserIds { get; set; }
        public string Users { get; set; }

    }
}
