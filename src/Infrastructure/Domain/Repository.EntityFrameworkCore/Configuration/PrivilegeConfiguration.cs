using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optivem.Northwind.Core.Domain.Entity;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore.Configuration
{
    public class PrivilegeConfiguration : IEntityTypeConfiguration<Privilege>
    {
        public void Configure(EntityTypeBuilder<Privilege> builder)
        {
            builder.Property(e => e.PrivilegeName)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}