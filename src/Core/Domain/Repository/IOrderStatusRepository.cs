using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Framework.Core.Domain.Repositories;

namespace Optivem.Northwind.Core.Domain.Repository
{
    public interface IOrderStatusRepository : IRepository<OrderStatus, int>
    {
    }
}