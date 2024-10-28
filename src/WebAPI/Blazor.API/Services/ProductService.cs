using Blazor.Data;
using Blazor.API.Data.Entities;

namespace Blazor.API.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
    public class ProductService: IProductService
    {
        private readonly BlazorDBContext _blazorDBContext;

        public ProductService(BlazorDBContext blazorDBContext)
        {
            _blazorDBContext = blazorDBContext;
        }

        public List<Product> GetProducts()
        {
            try
            {
                return _blazorDBContext.Products.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
