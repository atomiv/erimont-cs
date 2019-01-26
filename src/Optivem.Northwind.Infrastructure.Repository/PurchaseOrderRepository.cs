using Optivem.Platform.Infrastructure.Common.Repository.EntityFramework;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Domain.Repository
{
	public class PurchaseOrderRepository : EntityFrameworkRepository<NorthwindContext, PurchaseOrder, int>, IPurchaseOrderRepository
	{
		public PurchaseOrderRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
