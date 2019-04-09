using Optivem.Platform.Infrastructure.Common.Repository.EntityFrameworkCore;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Domain.Repository.EntityFrameworkCore
{
	public class OrderStatusRepository : EntityFrameworkRepository<NorthwindContext, OrderStatus, int>, IOrderStatusRepository
	{
		public OrderStatusRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
