using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Framework.Infrastructure.Domain.Repositories.EntityFrameworkCore;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore
{
    public class OrderTaxStatusRepository : EntityFrameworkRepository<NorthwindContext, OrderTaxStatus, int>, IOrderTaxStatusRepository
    {
        public OrderTaxStatusRepository(NorthwindContext context)
            : base(context)
        {
        }
    }
}