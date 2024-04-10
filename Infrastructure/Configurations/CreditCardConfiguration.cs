using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Configurations;

public class CreditCardConfiguration : IEntityTypeConfiguration<CreditCard>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CreditCard> entity)
    {
        entity
    .HasKey(e => e.Id)
    .HasName("CreditCard_pkey");

        entity
            .Property(e => e.Designation)
            .HasMaxLength(100)
            .IsRequired();

        entity
            .Property(e => e.IssueDate)
            .HasMaxLength(100);

        entity
            .Property(e => e.ExpirationDate)
            .HasMaxLength(100)
            .IsRequired();

        entity
            .Property(e => e.CardNumber)
            .HasMaxLength(16)
            .IsRequired();

        entity
            .Property(e => e.CVV)
            .HasMaxLength(10)
            .IsRequired();

        entity
            .Property(e => e.CreditCardStatus)
            .HasMaxLength(100);

        entity
            .Property(e => e.CreditLimit)
            .HasMaxLength(100);

        entity
            .Property(e => e.InterestRate)
            .HasPrecision(20, 5)
            .IsRequired();

        entity
            .Property(d => d.Availablecredit)
            .HasPrecision(20, 5);

        entity
            .Property(d => d.Currentdebt)
            .HasPrecision(20, 5);


    }
}
