using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class MovementConfiguration : IEntityTypeConfiguration<Movement>
{
    public void Configure(EntityTypeBuilder<Movement> builder)
    {
        builder.HasKey(m => m.Id);

        builder.Property(m => m.Destination)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(m => m.Amount)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(m => m.TransferredDateTime)
            .IsRequired();

        builder.Property(m => m.TransferStatus)
            .IsRequired();

        builder.HasOne(m => m.Account)
            .WithMany(a => a.Movements)
            .HasForeignKey(m => m.AccountId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}


