using Optivem.Commons.Persistence.EntityFramework;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Repository
{
    public class CustomerRepository : EntityFrameworkRepository<NorthwindContext, Customer, string>, ICustomerRepository
	{
		public CustomerRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
