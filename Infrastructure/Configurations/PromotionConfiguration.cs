using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class PromotionConfiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> entity)
        {
            entity.ToTable("Promotions");

            entity
                .HasKey(e => e.Id)
                .HasName("Promotion_pkey");

            entity
                .Property(e => e.Start)
                .IsRequired();

            entity
                .Property(e => e.End)
                .IsRequired();

            entity
                .Property(e => e.Discount)
                .IsRequired();

           
            entity
                .HasMany(e => e.PromotionsEnterprises)
                .WithOne(pe => pe.Promotion)
                .HasForeignKey(pe => pe.PromotionId);
        }
    }
}
