using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optivem.Northwind.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Optivem.Northwind.Infrastructure.Domain.Repository.EFCore.Configuration
{
    public class PurchaseOrderDetailConfiguration : IEntityTypeConfiguration<PurchaseOrderDetail>
    {
        public void Configure(EntityTypeBuilder<PurchaseOrderDetail> builder)
        {
            builder.Property(e => e.DateReceived).HasColumnType("datetime");

            builder.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");

            builder.Property(e => e.UnitCost).HasColumnType("money");

            builder.HasOne(d => d.Inventory)
                .WithMany(p => p.PurchaseOrderDetail)
                .HasForeignKey(d => d.InventoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderDetail_InventoryTransaction");

            builder.HasOne(d => d.Product)
                .WithMany(p => p.PurchaseOrderDetail)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderDetail_Product");

            builder.HasOne(d => d.PurchaseOrder)
                .WithMany(p => p.PurchaseOrderDetail)
                .HasForeignKey(d => d.PurchaseOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderDetail_PurchaseOrder");
        }
    }
}
