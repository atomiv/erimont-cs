using Optivem.Northwind.Core.Domain.Entities;
using Optivem.Northwind.Core.Domain.Repositories;
using Optivem.Framework.Infrastructure.Domain.Repositories.EntityFrameworkCore;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore
{
    public class PurchaseOrderStatusRepository : EntityFrameworkRepository<NorthwindContext, PurchaseOrderStatus, int>, IPurchaseOrderStatusRepository
    {
        public PurchaseOrderStatusRepository(NorthwindContext context)
            : base(context)
        {
        }
    }
}