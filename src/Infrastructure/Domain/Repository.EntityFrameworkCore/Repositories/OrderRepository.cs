using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Framework.Infrastructure.Domain.Repositories.EntityFrameworkCore;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore
{
    public class OrderRepository : EntityFrameworkRepository<NorthwindContext, Order, int>, IOrderRepository
    {
        public OrderRepository(NorthwindContext context)
            : base(context)
        {
        }
    }
}