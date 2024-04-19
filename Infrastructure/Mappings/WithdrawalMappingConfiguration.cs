using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class WithdrawalMappingConfiguration : IEntityTypeConfiguration<Withdrawal>
{
    public void Configure(EntityTypeBuilder<Withdrawal> builder)
    {
        builder.ToTable("Withdrawals");

        builder.HasKey(w => w.Id);

        builder.Property(w => w.AccountId)
            .IsRequired();

        builder.Property(w => w.BankId)
            .IsRequired();

        builder.Property(w => w.Amount)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(w => w.OperationDate)
            .IsRequired();
    }
}

