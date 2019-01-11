using Optivem.Commons.Persistence.EntityFramework;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Repository
{
	public class OrderTaxStatusRepository : EntityFrameworkRepository<NorthwindContext, OrderTaxStatus, int>, IOrderTaxStatusRepository
	{
		public OrderTaxStatusRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
