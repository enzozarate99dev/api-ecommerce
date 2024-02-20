using api_ecommerce.DTOs.Responses;
using api_ecommerce.Models;

namespace api_ecommerce.Services
{
    public interface IProductService
    {
        public Task<List<ProductResponse>> GetAllProducts();
        public ProductResponse GetProductById(int id);
        public bool UpdateProduct(Product product);
        public bool DeleteProduct(int id);
        public void CreateProduct(ProductRequest product);
    }
}
