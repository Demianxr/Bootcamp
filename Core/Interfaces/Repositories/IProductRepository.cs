using Core.Entities;

namespace Core.Interfaces.Repositories
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        Product GetProductById(int productId);
        IEnumerable<Product> GetAllProducts();
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);
    }
}
