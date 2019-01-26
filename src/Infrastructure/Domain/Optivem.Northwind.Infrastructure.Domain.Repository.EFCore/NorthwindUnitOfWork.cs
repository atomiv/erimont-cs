using Optivem.Platform.Infrastructure.Common.Repository.EntityFramework;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Domain.Repository.EntityFrameworkCore
{
    public class NorthwindUnitOfWork : EntityFrameworkUnitOfWork<NorthwindContext>, INorthwindUnitOfWork
    {
        public NorthwindUnitOfWork(NorthwindContext context)
            : base(context)
        {
            SupplierRepository = new SupplierRepository(context);
			CustomerRepository = new CustomerRepository(context);
			EmployeeRepository = new EmployeeRepository(context);
			EmployeePrivilegeRepository = new EmployeePrivilegeRepository(context);
			InventoryTransactionRepository = new InventoryTransactionRepository(context);
			InventoryTransactionTypeRepository = new InventoryTransactionTypeRepository(context);
			InvoiceRepository = new InvoiceRepository(context);
			OrderRepository = new OrderRepository(context);
			OrderDetailRepository = new OrderDetailRepository(context);
			OrderDetailStatusRepository = new OrderDetailStatusRepository(context);
			OrderStatusRepository = new OrderStatusRepository(context);
			OrderTaxStatusRepository = new OrderTaxStatusRepository(context);
			PrivilegeRepository = new PrivilegeRepository(context);
			ProductRepository = new ProductRepository(context);
			PurchaseOrderRepository = new PurchaseOrderRepository(context);
			PurchaseOrderDetailRepository = new PurchaseOrderDetailRepository(context);
			PurchaseOrderStatusRepository = new PurchaseOrderStatusRepository(context);
			ShipperRepository = new ShipperRepository(context);
		}

        public ISupplierRepository SupplierRepository { get; private set; }
		public ICustomerRepository CustomerRepository { get; private set; }
		public IEmployeeRepository EmployeeRepository { get; private set; }
		public IEmployeePrivilegeRepository EmployeePrivilegeRepository { get; private set; }
		public IInventoryTransactionRepository InventoryTransactionRepository { get; private set; }
		public IInventoryTransactionTypeRepository InventoryTransactionTypeRepository { get; private set; }
		public IInvoiceRepository InvoiceRepository { get; private set; }
		public IOrderRepository OrderRepository { get; private set; }
		public IOrderDetailRepository OrderDetailRepository { get; private set; }
		public IOrderDetailStatusRepository OrderDetailStatusRepository { get; private set; }
		public IOrderStatusRepository OrderStatusRepository { get; private set; }
		public IOrderTaxStatusRepository OrderTaxStatusRepository { get; private set; }
		public IPrivilegeRepository PrivilegeRepository { get; private set; }
		public IProductRepository ProductRepository { get; private set; }
		public IPurchaseOrderRepository PurchaseOrderRepository { get; private set; }
		public IPurchaseOrderDetailRepository PurchaseOrderDetailRepository { get; private set; }
		public IPurchaseOrderStatusRepository PurchaseOrderStatusRepository { get; private set; }
		public IShipperRepository ShipperRepository { get; private set; }



	}
}
