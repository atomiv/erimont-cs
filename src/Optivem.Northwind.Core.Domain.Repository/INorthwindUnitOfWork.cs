using Optivem.Commons.Persistence;

namespace Optivem.Northwind.Core.Domain.Repository
{
    public interface INorthwindUnitOfWork : IUnitOfWork
    {
        ISupplierRepository SupplierRepository { get; }

		IProductRepository ProductRepository { get; }

		IRegionRepository RegionRepository { get; }

		ICategoryRepository CategoryRepository { get; }

		ICustomerRepository CustomerRepository { get; }

		ICustomerCustomerDemoRepository CustomerCustomerDemoRepository { get; }

		ICustomerDemographicRepository CustomerDemographicRepository { get; }

		IEmployeeRepository EmployeeRepository { get; }

		IEmployeeTerritoryRepository EmployeeTerritoryRepository { get; }

		IOrderRepository OrderRepository { get; }

		IOrderDetailRepository OrderDetailRepository { get; }
	}
}
