using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optivem.Northwind.Infrastructure.EntityFrameworkCore.Suppliers.Records;

namespace Optivem.Northwind.Infrastructure.EntityFrameworkCore.Suppliers.Configurations
{
    public class SupplierConfiguration : IEntityTypeConfiguration<SupplierRecord>
    {
        public void Configure(EntityTypeBuilder<SupplierRecord> builder)
        {
            builder.Property(e => e.Address)
                .IsRequired();

            builder.Property(e => e.BusinessPhone)
                .IsRequired()
                .HasMaxLength(25);

            builder.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Company)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.CountryRegion)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.EmailAddress)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.FaxNumber)
                .HasMaxLength(25);

            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.HomePhone)
                .HasMaxLength(25);

            builder.Property(e => e.JobTitle)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.MobilePhone)
                .IsRequired()
                .HasMaxLength(25);

            builder.Property(e => e.StateProvince)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.ZipPostalCode)
                .IsRequired()
                .HasMaxLength(15);
        }
    }
}
