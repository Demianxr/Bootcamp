using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankAPI
{
    public class DepositMappingConfiguration : IEntityTypeConfiguration<Deposit>
    {
        public void Configure(EntityTypeBuilder<Deposit> builder)
        {
            builder.HasKey(d => d.AccountId);

            builder.Property(d => d.AccountId)
                .IsRequired();

            builder.Property(d => d.BankId)
                .IsRequired();

            builder.Property(d => d.Amount)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(d => d.TransactionDate)
                .IsRequired();
        }
    }
}
