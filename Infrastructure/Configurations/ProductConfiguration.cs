using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.EntityConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id); // Set primary key

     //       builder.Property(p => p.Name)
     //           .IsRequired() // Set name as required
//                .HasMaxLength(ProductConstants.MaxProductNameLength); // Set maximum length from Constants

   //         builder.Property(p => p.Description)
  //              .HasMaxLength(ProductConstants.MaxProductDescriptionLength); // Set maximum length from Constants

            builder.Property(p => p.ProductType)
                .IsRequired(); // Set ProductType as required

            builder.Property(p => p.Status)
                .IsRequired(); // Set Status as required
        }
    }
}
