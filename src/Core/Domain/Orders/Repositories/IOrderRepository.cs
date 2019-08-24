using Optivem.Framework.Core.Domain;
using Optivem.Northwind.Core.Domain.Orders.Entities;
using Optivem.Northwind.Core.Domain.Orders.ValueObjects;

namespace Optivem.Northwind.Core.Domain.Orders.Repositories
{
    public interface IOrderRepository : ICrudRepository<Order, OrderIdentity>, IPageAggregatesRepository<Order, OrderIdentity>
    {
    }
}