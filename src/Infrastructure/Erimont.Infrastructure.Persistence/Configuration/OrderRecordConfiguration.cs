﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Erimont.Infrastructure.Persistence.Records;

namespace Erimont.Infrastructure.Persistence.Configuration
{
    public class OrderRecordConfiguration : IEntityTypeConfiguration<OrderRecord>
    {
        public void Configure(EntityTypeBuilder<OrderRecord> builder)
        {
            builder.Property(e => e.Id)
                .ValueGeneratedNever();

            builder.HasOne(e => e.Customer)
                .WithMany(e => e.Orders)
                .HasForeignKey(e => e.CustomerId);

            builder.HasOne(e => e.OrderStatus)
                .WithMany(e => e.OrderRecords)
                .HasForeignKey(e => e.OrderStatusId);
        }
    }
}