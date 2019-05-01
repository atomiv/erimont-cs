using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optivem.Northwind.Core.Domain.Entity;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore.Configuration
{
    public class PurchaseOrderConfiguration : IEntityTypeConfiguration<PurchaseOrder>
    {
        public void Configure(EntityTypeBuilder<PurchaseOrder> builder)
        {
            builder.Property(e => e.ApprovedDate)
                .HasColumnType("datetime");

            builder.Property(e => e.CreationDate)
                .HasColumnType("datetime");

            builder.Property(e => e.ExpectedDate)
                .HasColumnType("datetime");

            builder.Property(e => e.PaymentAmount)
                .HasColumnType("money");

            builder.Property(e => e.PaymentDate)
                .HasColumnType("datetime");

            builder.Property(e => e.PaymentMethod)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.ShippingFee)
                .HasColumnType("money");

            builder.Property(e => e.SubmittedDate)
                .HasColumnType("datetime");

            builder.Property(e => e.Taxes)
                .HasColumnType("money");

            builder.HasOne(d => d.CreatedByNavigation)
                .WithMany(p => p.PurchaseOrder)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrder_Employee");

            builder.HasOne(d => d.Status)
                .WithMany(p => p.PurchaseOrder)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrder_PurchaseOrderStatus");

            builder.HasOne(d => d.Supplier)
                .WithMany(p => p.PurchaseOrder)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrder_Supplier");
        }
    }
}