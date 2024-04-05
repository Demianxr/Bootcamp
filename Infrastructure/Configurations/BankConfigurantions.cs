using AngleSharp.Dom;
using Microsoft.EntityFrameworkCore;
using Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class BankConfigurantions : IEntityTypeConfiguration<Bank>
    {

        public void Configure(EntityTypeBuilder<Bank> entity)
        {
            entity.HasKey(e => e.Id).HasName("Bank_pkey");

            entity.Property(e => e.Name).HasMaxLength(100);

            entity.Property(e => e.Phone).HasMaxLength(20);

            entity.Property(e => e.Mail).HasMaxLength(100);

            entity.Property(e => e.Address).HasMaxLength(100);

            entity
            .HasMany(bank => bank.Customers)
            .WithOne(customer => customer.Bank)
            .HasForeignKey(customer => customer.BankId);

        }
    }
}
