using System.ComponentModel;

namespace Shared.Lib.Dto
{
    public class MyLinksDto
    {
        public long Id { get; set; }
        [DisplayName("ACA Exchange Plan Link")]
        public string ACALink { get; set; }
        [DisplayName("Short Term Plan Link")]
        public string ShortTermLink { get; set; }
        [DisplayName("Life Plan Link")]
        public string LifePlanLink { get; set; }
        [DisplayName("Accident Plan Link")]
        public string AccidentPlanLink { get; set; }
        [DisplayName("Critical Illness Plan Link")]
        public string CriticalIllnessPlanLink { get; set; }
        [DisplayName("Hospital Indemnity Plan Link")]
        public string HospitalIndemnityPlanLink { get; set; }
        [DisplayName("Dental Plan Link")]
        public string DentalPlanLink { get; set; }
        [DisplayName("Vision Plan Link")]
        public string VisionPlanLink { get; set; }
    }
}
