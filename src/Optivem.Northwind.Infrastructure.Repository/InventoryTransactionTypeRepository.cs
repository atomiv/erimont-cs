using Optivem.Platform.Infrastructure.Common.Repository.EntityFramework;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Domain.Repository
{
	public class InventoryTransactionTypeRepository : EntityFrameworkRepository<NorthwindContext, InventoryTransactionType, int>, IInventoryTransactionTypeRepository
	{
		public InventoryTransactionTypeRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
