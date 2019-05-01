using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Framework.Infrastructure.Domain.Repositories.EntityFrameworkCore;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore
{
    public class OrderDetailStatusRepository : EntityFrameworkRepository<NorthwindContext, OrderDetailStatus, int>, IOrderDetailStatusRepository
    {
        public OrderDetailStatusRepository(NorthwindContext context)
            : base(context)
        {
        }
    }
}