using Optivem.Commons.Persistence.EntityFramework;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Repository
{
    public class NorthwindUnitOfWork : EntityFrameworkUnitOfWork<NorthwindContext>, INorthwindUnitOfWork
    {
        public NorthwindUnitOfWork(NorthwindContext context)
            : base(context)
        {
            SupplierRepository = new SupplierRepository(context);
			ProductRepository = new ProductRepository(context);
			RegionRepository = new RegionRepository(context);
			CategoryRepository = new CategoryRepository(context);
			CustomerRepository = new CustomerRepository(context);
			CustomerCustomerDemoRepository = new CustomerCustomerDemoRepository(context);
			CustomerDemographicRepository = new CustomerDemographicRepository(context);
			EmployeeRepository = new EmployeeRepository(context);
		}

        public ISupplierRepository SupplierRepository { get; private set; }

		public IProductRepository ProductRepository { get; private set; }

		public IRegionRepository RegionRepository { get; private set; }

		public ICategoryRepository CategoryRepository { get; private set; }

		public ICustomerRepository CustomerRepository { get; private set; }

		public ICustomerCustomerDemoRepository CustomerCustomerDemoRepository { get; private set; }

		public ICustomerDemographicRepository CustomerDemographicRepository { get; private set; }

		public IEmployeeRepository EmployeeRepository { get; private set; }

	}
}
