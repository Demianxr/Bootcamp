﻿using Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users"); 

            builder.HasKey(u => u.Id); 

            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(50); 


            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100); 

            builder.Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(200); 

        }
    }
}
