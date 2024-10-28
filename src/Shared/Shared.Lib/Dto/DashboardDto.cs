using System.Collections.Generic;

namespace Shared.Lib.Dto
{
    public class DashboardDto
    {
        public DashboardDto()
        {
            this.RecentUsers = new List<DashboardUserDto>();
            this.RecentLeads = new List<AdminLeadGridDto>();
        }
        public int TotalPendingRegistration { get; set; }
        public int TotalActiveUser { get; set; }
        public long TotalLeade { get; set; }
        public List<DashboardUserDto> RecentUsers { get; set; }
        public List<AdminLeadGridDto> RecentLeads { get; set; }
    }
   
    public class DashboardCarrierDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long Count { get; set; }
    }

    public class DashboardUserDto
    {
        public string Name { get; set; }
        public long Id { get; set; }
        public string ProfilePic { get; set; }
    }

}
