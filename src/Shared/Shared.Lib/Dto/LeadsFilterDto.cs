using System;
using System.Collections.Generic;
using System.Text;

namespace AsOnePlatform.Dto
{
    public class LeadsFilterDto
    {
        public int Id { get; set; }
        public byte LeadType { get; set; }
        public string StateCode { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public string ZipCode { get; set; }
        public int LeadAge { get; set; }
        public byte PhoneNumberPreference { get; set; }
    }

}