using Optivem.Platform.Infrastructure.Common.Repository.EntityFrameworkCore;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Domain.Repository.EntityFrameworkCore
{
	public class PurchaseOrderRepository : EntityFrameworkRepository<NorthwindContext, PurchaseOrder, int>, IPurchaseOrderRepository
	{
		public PurchaseOrderRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
