using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optivem.Northwind.Core.Domain.Entities;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore.Configuration
{
    internal class InventoryTransactionConfiguration : IEntityTypeConfiguration<InventoryTransaction>
    {
        public void Configure(EntityTypeBuilder<InventoryTransaction> builder)
        {
            builder.Property(e => e.Comments)
                .HasMaxLength(255);

            builder.Property(e => e.TransactionCreatedDate)
                .HasColumnType("datetime");

            builder.Property(e => e.TransactionModifiedDate)
                .HasColumnType("datetime");

            builder.HasOne(d => d.CustomerOrder)
                .WithMany(p => p.InventoryTransaction)
                .HasForeignKey(d => d.CustomerOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryTransaction_Order");

            builder.HasOne(d => d.Product)
                .WithMany(p => p.InventoryTransaction)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryTransaction_Product");

            builder.HasOne(d => d.PurchaseOrder)
                .WithMany(p => p.InventoryTransaction)
                .HasForeignKey(d => d.PurchaseOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryTransaction_PurchaseOrder");

            builder.HasOne(d => d.TransactionType)
                .WithMany(p => p.InventoryTransaction)
                .HasForeignKey(d => d.TransactionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryTransaction_InventoryTransactionType");
        }
    }
}