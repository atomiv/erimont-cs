using Optivem.Northwind.Core.Domain.Entities;
using Optivem.Northwind.Core.Domain.Repositories;
using Optivem.Framework.Infrastructure.Domain.Repositories.EntityFrameworkCore;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore
{
    public class InventoryTransactionRepository : EntityFrameworkRepository<NorthwindContext, InventoryTransaction, int>, IInventoryTransactionRepository
    {
        public InventoryTransactionRepository(NorthwindContext context)
            : base(context)
        {
        }
    }
}