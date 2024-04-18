using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace Infrastructure.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(t => t.IdTransaction);
            builder.Property(t => t.Type).IsRequired();
            builder.Property(t => t.AccountId).IsRequired();
            builder.Property(t => t.Amount).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(t => t.TransactionDate).IsRequired();
            builder.Property(t => t.Description).HasMaxLength(255);

            
        }
    }
}
