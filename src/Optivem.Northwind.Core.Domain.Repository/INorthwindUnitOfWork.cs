using Optivem.Commons.Persistence;

namespace Optivem.Northwind.Core.Domain.Repository
{
    public interface INorthwindUnitOfWork : IUnitOfWork
    {
        ISupplierRepository SupplierRepository { get; }
		ICustomerRepository CustomerRepository { get; }
		IEmployeeRepository EmployeeRepository { get; }
		IEmployeePrivilegeRepository EmployeePrivilegeRepository { get; }
		IInventoryTransactionRepository InventoryTransactionRepository { get; }
		IInventoryTransactionTypeRepository InventoryTransactionTypeRepository { get; }
		IInvoiceRepository InvoiceRepository { get; }
		IOrderRepository OrderRepository { get; }
		IOrderDetailRepository OrderDetailRepository { get; }
		IOrderDetailStatusRepository OrderDetailStatusRepository { get; }
		IOrderStatusRepository OrderStatusRepository { get; }
		IOrderTaxStatusRepository OrderTaxStatusRepository { get; }
		IPrivilegeRepository PrivilegeRepository { get; }
		IProductRepository ProductRepository { get; }
		IPurchaseOrderRepository PurchaseOrderRepository { get; }
		IPurchaseOrderDetailRepository PurchaseOrderDetailRepository { get; }
		IPurchaseOrderStatusRepository PurchaseOrderStatusRepository { get; }
		IShipperRepository ShipperRepository { get; }
	}
}
