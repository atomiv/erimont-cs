using Optivem.Platform.Infrastructure.Common.Repository.EntityFrameworkCore;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Domain.Repository.EntityFrameworkCore
{
	public class PurchaseOrderDetailRepository : EntityFrameworkRepository<NorthwindContext, PurchaseOrderDetail, int>, IPurchaseOrderDetailRepository
	{
		public PurchaseOrderDetailRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
