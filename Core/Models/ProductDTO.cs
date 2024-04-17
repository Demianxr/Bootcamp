using Core.Constants;
using Core.Entities;

namespace Core.Models
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductType ProductType { get; set; }
        public ProductStatus Status { get; set; }
        public Currency Currency { get; set; }  
       
    }
}
