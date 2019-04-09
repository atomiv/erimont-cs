using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Infrastructure.Domain.Repository.EFCore.Configuration;

namespace Optivem.Northwind.Infrastructure.Domain.Repository.EntityFrameworkCore
{
    public partial class NorthwindContext : DbContext
    {
        public NorthwindContext()
        {
        }

        public NorthwindContext(DbContextOptions<NorthwindContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }

        public virtual DbSet<Employee> Employee { get; set; }

        public virtual DbSet<EmployeePrivilege> EmployeePrivilege { get; set; }

        public virtual DbSet<InventoryTransaction> InventoryTransaction { get; set; }

        public virtual DbSet<InventoryTransactionType> InventoryTransactionType { get; set; }

        public virtual DbSet<Invoice> Invoice { get; set; }

        public virtual DbSet<Order> Order { get; set; }

        public virtual DbSet<OrderDetail> OrderDetail { get; set; }

        public virtual DbSet<OrderDetailStatus> OrderDetailStatus { get; set; }

        public virtual DbSet<OrderStatus> OrderStatus { get; set; }

        public virtual DbSet<OrderTaxStatus> OrderTaxStatus { get; set; }

        public virtual DbSet<Privilege> Privilege { get; set; }

        public virtual DbSet<Product> Product { get; set; }

        public virtual DbSet<PurchaseOrder> PurchaseOrder { get; set; }

        public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetail { get; set; }

        public virtual DbSet<PurchaseOrderStatus> PurchaseOrderStatus { get; set; }

        public virtual DbSet<Shipper> Shipper { get; set; }

        public virtual DbSet<Supplier> Supplier { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeePrivilegeConfiguration());
            modelBuilder.ApplyConfiguration(new InventoryTransactionConfiguration());
            modelBuilder.ApplyConfiguration(new InventoryTransactionTypeConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailStatusConfiguration());
            modelBuilder.ApplyConfiguration(new OrderStatusConfiguration());
            modelBuilder.ApplyConfiguration(new OrderTaxStatusConfiguration());
            modelBuilder.ApplyConfiguration(new PrivilegeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new PurchaseOrderConfiguration());
            modelBuilder.ApplyConfiguration(new PurchaseOrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new PurchaseOrderStatusConfiguration());
            modelBuilder.ApplyConfiguration(new ShipperConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierConfiguration());

            // TODO: VC: Check whether to use singular or plural
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                entityType.Relational().TableName = entityType.DisplayName();
            }
        }
    }
}