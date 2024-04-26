using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Entities;

namespace Infrastructure.Data.Config
{
    public class TransferConfiguration : IEntityTypeConfiguration<Transfer>
    {
        public void Configure(EntityTypeBuilder<Transfer> builder)
        {
            builder.HasKey(t => t.Id);

            // Configura las relaciones con otras entidades (si es necesario)
             //builder.HasOne(t => t.OriginAccount).WithMany().HasForeignKey(t => t.OriginAccountId);
             //builder.HasOne(t => t.DestinationAccount).WithMany().HasForeignKey(t => t.DestinationAccountId);

            // Configura propiedades (si es necesario)
            // builder.Property(t => t.Amount).HasColumnType("decimal(18, 2)");

            // Validaciones personalizadas
            builder.HasCheckConstraint("CHK_SameCurrency", "[OriginAccountId] <> [DestinationAccountId]");
            builder.HasCheckConstraint("CHK_AmountPositive", "[Amount] > 0");
            builder.HasCheckConstraint("CHK_OriginAccountActive", "[OriginAccount].[IsActive] = 1");
            builder.HasCheckConstraint("CHK_WithinOperationalLimit", "[Amount] <= [OriginAccount].[OperationalLimit]");

            // Otros ajustes de configuración según tus necesidades
        }
    }
}
