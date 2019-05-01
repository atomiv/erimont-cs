using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optivem.Northwind.Core.Domain.Entity;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(e => e.OrderDate)
                .HasColumnType("datetime");

            builder.Property(e => e.PaidDate)
                .HasColumnType("datetime");

            builder.Property(e => e.PaymentType)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.ShipAddress)
                .IsRequired();

            builder.Property(e => e.ShipCity)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.ShipCountryRegion)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.ShipName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.ShipStateProvince)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.ShipZipPostalCode)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.ShippedDate)
                .HasColumnType("datetime");

            builder.Property(e => e.ShippingFee)
                .HasColumnType("money");

            builder.Property(e => e.Taxes)
                .HasColumnType("money");

            builder.HasOne(d => d.Customer)
                .WithMany(p => p.Order)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Customer");

            builder.HasOne(d => d.Employee)
                .WithMany(p => p.Order)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Employee");

            builder.HasOne(d => d.Shipper)
                .WithMany(p => p.Order)
                .HasForeignKey(d => d.ShipperId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Shipper");

            builder.HasOne(d => d.Status)
                .WithMany(p => p.Order)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_OrderStatus");

            builder.HasOne(d => d.TaxStatus)
                .WithMany(p => p.Order)
                .HasForeignKey(d => d.TaxStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_OrderTaxStatus");
        }
    }
}