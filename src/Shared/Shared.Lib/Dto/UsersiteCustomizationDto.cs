using System.Collections.Generic;

namespace Shared.Lib.Dto
{
    public class UserSiteCustomizationDto
    {
        public long? Id { get; set; }
        public string BodyBackGroundColor { get; set; }
        public string HeaderBackGroundColor { get; set; }
        public string NavigationtextColor { get; set; }
        public string SubNavigationBGColor { get; set; }
        public string NavigationBackGroundColor { get; set; }
        public string FooterTitleColor { get; set; }
        public string FooterTextColorH { get; set; }
        public string FooterBackGroundColor { get; set; }
        public string Logo { get; set; }
        public string NavigationtextSize { get; set; }
        public string FooterTitleTextSize { get; set; }
        public string FacebookLink { get; set; }
        public string TwitterLink { get; set; }
        public string LinkedInLink { get; set; }
        public string GooglePlusLink { get; set; }
    }

    public class MainMenuDto
    {
        public MainMenuDto()
        {
            List<ClientMenuDto> SubMenu = new List<ClientMenuDto>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int SequenceId { get; set; }
        public List<ClientMenuDto> SubMenu { get; set; }

    }
    public class ClientMenuDto
    {
      
        public long Id { get; set; }
        public long MainMenuId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int SequenceId { get; set; }
    }
}
