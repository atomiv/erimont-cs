using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optivem.Northwind.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Optivem.Northwind.Infrastructure.Domain.Repository.EFCore.Configuration
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.Property(e => e.DateAllocated).HasColumnType("datetime");

            builder.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");

            builder.Property(e => e.UnitPrice).HasColumnType("money");

            builder.HasOne(d => d.Order)
                .WithMany(p => p.OrderDetail)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetail_Order");

            builder.HasOne(d => d.Product)
                .WithMany(p => p.OrderDetail)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetail_Product");

            builder.HasOne(d => d.Status)
                .WithMany(p => p.OrderDetail)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetail_OrderDetailStatus");
        }
    }
}
