using Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Configurations
{
    public class UserRequestConfiguration : IEntityTypeConfiguration<UserRequest>
    {
        public void Configure(EntityTypeBuilder<UserRequest> builder)
        {
            builder.ToTable("UserRequests");

            builder.HasKey(ur => ur.Id);
            
            builder.Property(ur => ur.ProductType)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(ur => ur.Amount)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(ur => ur.Currency)
                .IsRequired()
                .HasMaxLength(3);

            builder.Property(ur => ur.RequestDate)
                .IsRequired();

            builder.Property(ur => ur.ApprovalDate)
                .IsRequired();
        }
    }
}