using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Framework.Infrastructure.Domain.Repositories.EntityFrameworkCore;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore
{
    public class OrderDetailRepository : EntityFrameworkRepository<NorthwindContext, OrderDetail, int>, IOrderDetailRepository
    {
        public OrderDetailRepository(NorthwindContext context)
            : base(context)
        {
        }
    }
}