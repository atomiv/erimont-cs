using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optivem.Northwind.Core.Domain.Entities;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore.Configuration
{
    public class PurchaseOrderStatusConfiguration : IEntityTypeConfiguration<PurchaseOrderStatus>
    {
        public void Configure(EntityTypeBuilder<PurchaseOrderStatus> builder)
        {
            builder.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}