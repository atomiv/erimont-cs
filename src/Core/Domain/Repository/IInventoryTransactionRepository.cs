using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Framework.Core.Domain.Repositories;

namespace Optivem.Northwind.Core.Domain.Repository
{
    public interface IInventoryTransactionRepository : IRepository<InventoryTransaction, int>
    {
    }
}