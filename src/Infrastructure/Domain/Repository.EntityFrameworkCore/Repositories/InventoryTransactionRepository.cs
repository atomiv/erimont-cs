using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Platform.Infrastructure.Common.Repository.EntityFrameworkCore;

namespace Optivem.Northwind.Infrastructure.Domain.Repository.EntityFrameworkCore
{
    public class InventoryTransactionRepository : EntityFrameworkRepository<NorthwindContext, InventoryTransaction, int>, IInventoryTransactionRepository
    {
        public InventoryTransactionRepository(NorthwindContext context)
            : base(context)
        {
        }
    }
}