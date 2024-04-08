using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrbanStore.Domain.Model;

namespace UrbanStore.Infra.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(30);
            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(500);
            builder.Property(x => x.Price)
                .IsRequired();
            builder.Property(x => x.Stock)
                .IsRequired();
            builder.Property(x => x.Image)
                .IsRequired();
            builder.Property(x => x.BrandId)
                .IsRequired();
            builder.Property(x => x.CategoryId)
                .IsRequired();
        }
    }
}