namespace Shared.Lib.Dto
{
    public class CarrierDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }        
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsACA { get; set; }
        public bool ShowInGraph { get; set; }
        public int GraphSequenceNumber { get; set; }
    }


    public class CarrierGridDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public string ShowInGraph { get; set; }
        public string IsACA { get; set; }
    }
}
