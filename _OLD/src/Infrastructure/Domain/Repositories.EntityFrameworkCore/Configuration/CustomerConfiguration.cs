using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optivem.Northwind.Core.Domain.Entities;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
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