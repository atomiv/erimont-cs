using Optivem.Platform.Infrastructure.Common.Repository.EntityFramework;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Domain.Repository
{
	public class OrderTaxStatusRepository : EntityFrameworkRepository<NorthwindContext, OrderTaxStatus, int>, IOrderTaxStatusRepository
	{
		public OrderTaxStatusRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
