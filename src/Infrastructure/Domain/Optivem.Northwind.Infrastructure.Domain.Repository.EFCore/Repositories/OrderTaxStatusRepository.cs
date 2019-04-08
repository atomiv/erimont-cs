using Optivem.Platform.Infrastructure.Common.Repository.EntityFrameworkCore;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Domain.Repository.EntityFrameworkCore
{
	public class OrderTaxStatusRepository : EntityFrameworkRepository<NorthwindContext, OrderTaxStatus, int>, IOrderTaxStatusRepository
	{
		public OrderTaxStatusRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
