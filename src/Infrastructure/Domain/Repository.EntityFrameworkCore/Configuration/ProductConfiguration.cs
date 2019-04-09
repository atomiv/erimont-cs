using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optivem.Northwind.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Optivem.Northwind.Infrastructure.Domain.Repository.EFCore.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(e => e.Category)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Description)
                .IsRequired();

            builder.Property(e => e.ListPrice)
                .HasColumnType("money");

            builder.Property(e => e.ProductCode)
                .IsRequired()
                .HasMaxLength(25);

            builder.Property(e => e.ProductName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.QuantityPerUnit)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.StandardCost)
                .HasColumnType("money");

            builder.Property(e => e.SupplierId)
                .IsRequired();
        }
    }
}
