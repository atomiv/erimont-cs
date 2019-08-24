using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optivem.Northwind.Core.Domain.Entities;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore.Configuration
{
    public class InventoryTransactionTypeConfiguration : IEntityTypeConfiguration<InventoryTransactionType>
    {
        public void Configure(EntityTypeBuilder<InventoryTransactionType> builder)
        {
            builder.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}