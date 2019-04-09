using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optivem.Northwind.Core.Domain.Entity;

namespace Optivem.Northwind.Infrastructure.Domain.Repository.EFCore.Configuration
{
    public class EmployeePrivilegeConfiguration : IEntityTypeConfiguration<EmployeePrivilege>
    {
        public void Configure(EntityTypeBuilder<EmployeePrivilege> builder)
        {
            builder.HasOne(d => d.Employee)
                .WithMany(p => p.EmployeePrivilege)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeePrivilege_Employee");

            builder.HasOne(d => d.Privilege)
                .WithMany(p => p.EmployeePrivilege)
                .HasForeignKey(d => d.PrivilegeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeePrivilege_Privilege");
        }
    }
}