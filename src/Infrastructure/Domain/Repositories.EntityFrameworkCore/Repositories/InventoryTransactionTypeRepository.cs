using Optivem.Northwind.Core.Domain.Entities;
using Optivem.Northwind.Core.Domain.Repositories;
using Optivem.Framework.Infrastructure.Domain.Repositories.EntityFrameworkCore;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore
{
    public class InventoryTransactionTypeRepository : EntityFrameworkRepository<NorthwindContext, InventoryTransactionType, int>, IInventoryTransactionTypeRepository
    {
        public InventoryTransactionTypeRepository(NorthwindContext context)
            : base(context)
        {
        }
    }
}