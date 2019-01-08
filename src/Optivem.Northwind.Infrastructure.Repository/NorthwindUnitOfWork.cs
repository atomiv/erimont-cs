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
		}

        public ISupplierRepository SupplierRepository { get; private set; }

	}
}
