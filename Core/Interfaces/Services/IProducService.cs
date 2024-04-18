using Core.Entities;
using Core.Models;
using Core.Requests;

namespace Core.Interfaces.Services
{
    public interface IProductService
    {
        ProductDTO GetProductById(int id);
        IEnumerable<ProductDTO> GetAllProducts();
        void CreateProduct(CreateProductModel productModel);
        void UpdateProduct(UpdateProductModel productModel);
        void DeleteProduct(int id);
    }
}
