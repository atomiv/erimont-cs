using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optivem.Northwind.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Optivem.Northwind.Infrastructure.Domain.Repository.EFCore.Configuration
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
