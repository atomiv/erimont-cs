using Optivem.Commons.Persistence.EntityFramework;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Repository
{
	public class OrderDetailStatusRepository : EntityFrameworkRepository<NorthwindContext, OrderDetailStatus, int>, IOrderDetailStatusRepository
	{
		public OrderDetailStatusRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
