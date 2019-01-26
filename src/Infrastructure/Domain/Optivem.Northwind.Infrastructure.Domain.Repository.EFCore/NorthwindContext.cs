using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Optivem.Northwind.Core.Domain.Entity;

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



			modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.BusinessPhone)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CountryRegion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FaxNumber).HasMaxLength(25);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HomePhone).HasMaxLength(25);

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MobilePhone)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.StateProvince)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ZipPostalCode)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.BusinessPhone)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CountryRegion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FaxNumber).HasMaxLength(25);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HomePhone).HasMaxLength(25);

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MobilePhone)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.StateProvince)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ZipPostalCode)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<EmployeePrivilege>(entity =>
            {
                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeePrivilege)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeePrivilege_Employee");

                entity.HasOne(d => d.Privilege)
                    .WithMany(p => p.EmployeePrivilege)
                    .HasForeignKey(d => d.PrivilegeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeePrivilege_Privilege");
            });

            modelBuilder.Entity<InventoryTransaction>(entity =>
            {
                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.TransactionCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CustomerOrder)
                    .WithMany(p => p.InventoryTransaction)
                    .HasForeignKey(d => d.CustomerOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventoryTransaction_Order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.InventoryTransaction)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventoryTransaction_Product");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.InventoryTransaction)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventoryTransaction_PurchaseOrder");

                entity.HasOne(d => d.TransactionType)
                    .WithMany(p => p.InventoryTransaction)
                    .HasForeignKey(d => d.TransactionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventoryTransaction_InventoryTransactionType");
            });

            modelBuilder.Entity<InventoryTransactionType>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.Property(e => e.AmountDue).HasColumnType("money");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.Shipping).HasColumnType("money");

                entity.Property(e => e.Tax).HasColumnType("money");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_Order");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShipAddress).IsRequired();

                entity.Property(e => e.ShipCity)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShipCountryRegion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShipName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShipStateProvince)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShipZipPostalCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShippedDate).HasColumnType("datetime");

                entity.Property(e => e.ShippingFee).HasColumnType("money");

                entity.Property(e => e.Taxes).HasColumnType("money");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Customer");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Employee");

                entity.HasOne(d => d.Shipper)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.ShipperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Shipper");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_OrderStatus");

                entity.HasOne(d => d.TaxStatus)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.TaxStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_OrderTaxStatus");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.Property(e => e.DateAllocated).HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetail)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetail_Order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetail)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetail_Product");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.OrderDetail)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetail_OrderDetailStatus");
            });

            modelBuilder.Entity<OrderDetailStatus>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OrderTaxStatus>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Privilege>(entity =>
            {
                entity.Property(e => e.PrivilegeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ListPrice).HasColumnType("money");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.QuantityPerUnit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StandardCost).HasColumnType("money");

                entity.Property(e => e.SupplierId).IsRequired();
            });

            modelBuilder.Entity<PurchaseOrder>(entity =>
            {
                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.ExpectedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentAmount).HasColumnType("money");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentMethod)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShippingFee).HasColumnType("money");

                entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

                entity.Property(e => e.Taxes).HasColumnType("money");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PurchaseOrder)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrder_Employee");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.PurchaseOrder)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrder_PurchaseOrderStatus");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PurchaseOrder)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrder_Supplier");
            });

            modelBuilder.Entity<PurchaseOrderDetail>(entity =>
            {
                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitCost).HasColumnType("money");

                entity.HasOne(d => d.Inventory)
                    .WithMany(p => p.PurchaseOrderDetail)
                    .HasForeignKey(d => d.InventoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderDetail_InventoryTransaction");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PurchaseOrderDetail)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderDetail_Product");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PurchaseOrderDetail)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderDetail_PurchaseOrder");
            });

            modelBuilder.Entity<PurchaseOrderStatus>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Shipper>(entity =>
            {
                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.BusinessPhone)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CountryRegion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FaxNumber).HasMaxLength(25);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HomePhone).HasMaxLength(25);

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MobilePhone)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.StateProvince)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ZipPostalCode)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.BusinessPhone)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CountryRegion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FaxNumber).HasMaxLength(25);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HomePhone).HasMaxLength(25);

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MobilePhone)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.StateProvince)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ZipPostalCode)
                    .IsRequired()
                    .HasMaxLength(15);
            });
			
			// Singular table names
			foreach (var entityType in modelBuilder.Model.GetEntityTypes())
			{
				entityType.Relational().TableName = entityType.DisplayName();
			}
		}
    }
}
