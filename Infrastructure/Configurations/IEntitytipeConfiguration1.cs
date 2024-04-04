using Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public interface IEntitytipeConfiguration<T>
    {
        void Configure(EntityTypeBuilder<Bank> entity);
    }
}