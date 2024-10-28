using System.Collections.Generic;

namespace Shared.Lib.Dto
{
    public class UserDashboardDto
    {
        public UserDashboardDto()
        {
            this.RecentLeads = new List<UserLeadGridDto>();
        }
        public int TotalLead { get; set; }
        public int TotalOpportunity { get; set; }
        public int TotalClient { get; set; }
        public int TotalEmployees { get; set; }
        public List<UserLeadGridDto> RecentLeads { get; set; }
    }
}
