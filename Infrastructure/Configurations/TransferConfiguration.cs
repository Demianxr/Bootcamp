using Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class TransferConfiguration : IEntityTypeConfiguration<Transfer>
{
    public void Configure(EntityTypeBuilder<Transfer> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.OriginAccountId).IsRequired();
        builder.Property(t => t.DestinationAccountId).IsRequired();
        builder.Property(t => t.Amount).IsRequired().HasColumnType("decimal(18,2)");
        builder.Property(t => t.TransferDate).IsRequired();

        //builder.HasOne(t => t.OriginAccount)
            //.WithMany(a => a.Movements)
            //.HasForeignKey(t => t.OriginAccountId)
            //.OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(t => t.DestinationAccount)
            .WithMany()
            .HasForeignKey(t => t.DestinationAccountId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
