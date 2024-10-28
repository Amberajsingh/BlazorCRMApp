namespace Shared.Lib.Dto
{
    public class ProductDto
    { 
        public long Id { get; set; }
        public string Name { get; set; }
        public string CarrierName { get; set; }
        public long CarrierId { get; set; }
        public long MenuId { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
        public bool IsActive { get; set; }
    }


    public class ProductGridDto
    {
        public ProductGridDto()
        {
            CarrierDto Carrier = new CarrierDto();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string CarrierName { get; set; }
        public string CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public CarrierDto Carrier { get; set; }
        public string MenuName { get; set; }
    }
}
