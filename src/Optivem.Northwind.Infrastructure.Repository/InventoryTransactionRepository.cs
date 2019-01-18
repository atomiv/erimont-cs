using Optivem.Infrastructure.Repository.EntityFramework;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Repository
{
	public class InventoryTransactionRepository : EntityFrameworkRepository<NorthwindContext, InventoryTransaction, int>, IInventoryTransactionRepository
	{
		public InventoryTransactionRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
