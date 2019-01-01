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
		}

        public ISupplierRepository SupplierRepository { get; private set; }

		public IProductRepository ProductRepository { get; private set; }

		public IRegionRepository RegionRepository { get; private set; }

		public ICategoryRepository CategoryRepository { get; private set; }

		public ICustomerRepository CustomerRepository { get; private set; }

	}
}
