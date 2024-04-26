using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class RequestConfiguration : IEntityTypeConfiguration<Request>
{
    public void Configure(EntityTypeBuilder<Request> entity)
    {

        entity
            .HasKey(e => e.Id)
            .HasName("Request_pkey");


        entity
            .Property(e => e.Description)
            .HasMaxLength(100)
            .IsRequired();

        entity
            .HasOne(userRequest => userRequest.Currency)
            .WithMany(currency => currency.Requests)
            .HasForeignKey(userRequest => userRequest.CurrencyId);

        entity
            .HasOne(userRequest => userRequest.Customer)
            .WithMany(customer => customer.Requests)
            .HasForeignKey(userRequest => userRequest.CustomerId);

        entity
           .HasOne(userRequest => userRequest.Product)
           .WithMany(product => product.Requests)
           .HasForeignKey(userRequest => userRequest.ProductId);
    }
}