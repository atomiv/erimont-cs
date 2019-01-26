using Optivem.Platform.Infrastructure.Common.Repository.EntityFramework;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Domain.Repository
{
	public class PurchaseOrderDetailRepository : EntityFrameworkRepository<NorthwindContext, PurchaseOrderDetail, int>, IPurchaseOrderDetailRepository
	{
		public PurchaseOrderDetailRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
