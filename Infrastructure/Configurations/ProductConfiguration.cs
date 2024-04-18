using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.EntityConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Amount).IsRequired();
            builder.Property(p => p.Term).IsRequired();
            builder.Property(p => p.Brand).HasMaxLength(50);
            builder.Property(p => p.InitialDeposit).IsRequired();
            builder.Property(p => p.Currency).IsRequired().HasMaxLength(3);
            builder.Property(p => p.RequestDate).IsRequired();
            builder.Property(p => p.ApprovalDate);
        }
    }
}
