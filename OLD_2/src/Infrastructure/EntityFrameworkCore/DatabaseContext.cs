using Microsoft.EntityFrameworkCore;
using Optivem.Northwind.Infrastructure.EntityFrameworkCore.Customers.Configurations;
using Optivem.Northwind.Infrastructure.EntityFrameworkCore.Customers.Records;
using Optivem.Northwind.Infrastructure.EntityFrameworkCore.Products.Records;
using Optivem.Northwind.Infrastructure.EntityFrameworkCore.Suppliers.Configurations;
using Optivem.Northwind.Infrastructure.EntityFrameworkCore.Suppliers.Records;

namespace Optivem.Northwind.Infrastructure.EntityFrameworkCore
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomerRecord> Customers { get; set; }

        public virtual DbSet<ProductRecord> Products { get; set; }

        public virtual DbSet<SupplierRecord> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TODO: VC: Check if needed
            // modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            // modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierConfiguration());

            // TODO: VC: Dynamically find everything implementing IEntityTypeConfiguration interface
        }
    }
}