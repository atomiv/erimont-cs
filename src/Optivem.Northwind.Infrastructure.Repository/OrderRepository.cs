using Optivem.Platform.Infrastructure.Common.Repository.EntityFramework;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Domain.Repository
{
	public class OrderRepository : EntityFrameworkRepository<NorthwindContext, Order, int>, IOrderRepository
	{
		public OrderRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
