using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class DepositConfiguration : IEntityTypeConfiguration<Deposit>
    {
        public void Configure(EntityTypeBuilder<Deposit> builder)
        {
            builder.HasKey(d => new { d.AccountId, d.BankId });

            builder.Property(d => d.Amount)
                .IsRequired();

            builder.Property(d => d.TransactionDate)
                .IsRequired();
        }
    }
}

