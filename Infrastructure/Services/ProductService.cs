using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Models;
using Core.Requests;
using MapsterMapper;

namespace Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper; // Added for mapping between models and DTOs

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper; // Initialize mapper for data transformation
        }

        public ProductDTO GetProductById(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product != null)
            {
                return _mapper.Map<ProductDTO>(product); // Use mapper for DTO conversion
            }
            return null;
        }

        public IEnumerable<ProductDTO> GetAllProducts()
        {
            var products = _productRepository.GetAllProducts();
            return _mapper.Map<IEnumerable<ProductDTO>>(products); // Use mapper for DTO collection conversion
        }

        public void CreateProduct(CreateProductModel productModel)
        {
            // Validate product data (consider adding validation logic here)
            var product = _mapper.Map<Product>(productModel); // Use mapper for model to entity conversion
            _productRepository.AddProduct(product);
        }

        public void UpdateProduct(UpdateProductModel productModel)
        {
            // Validate product data (consider adding validation logic here)
            var product = _productRepository.GetProductById(productModel.Id);
            if (product != null)
            {
                _mapper.Map(productModel, product); // Use mapper for update (consider selective mapping)
                _productRepository.UpdateProduct(product);
            }
        }

        public void DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id);
        }
    }
}
