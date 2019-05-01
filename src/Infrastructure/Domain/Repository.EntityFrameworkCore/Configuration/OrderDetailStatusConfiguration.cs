using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optivem.Northwind.Core.Domain.Entity;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore.Configuration
{
    public class OrderDetailStatusConfiguration : IEntityTypeConfiguration<OrderDetailStatus>
    {
        public void Configure(EntityTypeBuilder<OrderDetailStatus> builder)
        {
            builder.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}