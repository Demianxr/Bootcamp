using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Configurations
{
    public class CurrencyConfiguration : IEntityTypeConfiguration<Currency>
    {

        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Currency> entity)
        {
            entity.HasKey(e => e.Id).HasName("currency_pkey");

            entity.Property(e => e.Name).HasMaxLength(100);

            entity.Property(e => e.BuyValue).HasMaxLength(100);

            entity.Property(e => e.SellValue).HasMaxLength(100).IsRequired();

            entity
                .HasOne(d => d.Bank)
                .WithMany(p => p.Customers)
                .HasForeignKey(d => d.BankId);

        }
    }
}
