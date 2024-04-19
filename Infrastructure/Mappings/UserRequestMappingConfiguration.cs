using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class UserRequestMappingConfiguration : IEntityTypeConfiguration<UserRequest>
{
    public void Configure(EntityTypeBuilder<UserRequest> builder)
    {

        builder.HasKey(ur => ur.Id);


        builder.Property(ur => ur.ProductType)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(ur => ur.Amount)
            .IsRequired();

        builder.Property(ur => ur.Currency)
            .IsRequired()
            .HasMaxLength(3);

        builder.Property(ur => ur.RequestDate)
            .IsRequired();

        builder.Property(ur => ur.ApprovalDate);
    }
}

