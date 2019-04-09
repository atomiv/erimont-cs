using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optivem.Northwind.Core.Domain.Entity;

namespace Optivem.Northwind.Infrastructure.Domain.Repository.EFCore.Configuration
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