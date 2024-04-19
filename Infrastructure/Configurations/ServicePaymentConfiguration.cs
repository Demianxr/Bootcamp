using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ServicePaymentConfiguration : IEntityTypeConfiguration<ServicePayment>
{
    public void Configure(EntityTypeBuilder<ServicePayment> builder)
    {
        builder.HasKey(sp => sp.Id);

        builder.Property(sp => sp.DocumentNumber)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(sp => sp.Amount)
            .IsRequired();

        builder.Property(sp => sp.Description)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(sp => sp.DebitAccountId)
            .IsRequired();

        builder.Property(sp => sp.PaymentDate)
            .IsRequired();
    }
}

