using Core.Entities;
using Core.Models;

namespace Core.Interfaces.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
        List<ProductDTO> GetProductsAsDTO();
    }
}
