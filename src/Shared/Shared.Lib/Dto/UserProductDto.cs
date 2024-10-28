using System.Collections.Generic;

namespace Shared.Lib.Dto
{
    public class UserProductSave1Dto
    {
        public long UserId { get; set; }
        public long CarrierId { get; set; }
        public long ProductId { get; set; }
    }

    public class UserProductDto
    {
        public UserProductDto()
        {
            Carriers = new List<UserProductCarrierDto>();
        }
        public UserDto BasicDetails { get; set; }
        public List<UserProductCarrierDto> Carriers { get; set; }
    }


    public class UserProductCarrierDto
    {
        public UserProductCarrierDto()
        {
            this.Produccts = new List<SelectListDto>();
            this.CarrierProduccts = new List<UserProductCarrierDto>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public bool IsActive { get; set; }
        public bool IsAca { get; set; }
        public string CarrierUserId { get; set; }
        public List<SelectListDto> Produccts { get; set; }
        public List<UserProductCarrierDto> CarrierProduccts { get; set; }
    }

    public class UserProductSaveDto
    {       
        public long UserId { get; set; }
        public long CarrierId { get; set; }
        public bool IsActive { get; set; }
        public string CarrierUserId { get; set; }
        public string ProductIds { get; set; }
    }

    public class UserCarrierSaveDto
    {
        public long UserId { get; set; }
        public string CarrierIds { get; set; }
    }

    public class UserCarrierListDto
    {
       
        public long Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public bool IsActive { get; set; }
        public string[] IsEnabled { get; set; }
    }
    public class UserCarrierDto
    {

        public UserCarrierDto()
        {
            Carriers = new List<UserCarrierListDto>();
        }
        public UserDto BasicDetails { get; set; }
        public List<UserCarrierListDto> Carriers { get; set; }
    }
}
