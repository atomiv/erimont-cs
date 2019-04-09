using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optivem.Northwind.Core.Domain.Entity;

namespace Optivem.Northwind.Infrastructure.Domain.Repository.EFCore.Configuration
{
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.Property(e => e.AmountDue)
                .HasColumnType("money");

            builder.Property(e => e.DueDate)
                .HasColumnType("datetime");

            builder.Property(e => e.InvoiceDate)
                .HasColumnType("datetime");

            builder.Property(e => e.Shipping)
                .HasColumnType("money");

            builder.Property(e => e.Tax)
                .HasColumnType("money");

            builder.HasOne(d => d.Order)
                .WithMany(p => p.Invoice)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Invoice_Order");
        }
    }
}