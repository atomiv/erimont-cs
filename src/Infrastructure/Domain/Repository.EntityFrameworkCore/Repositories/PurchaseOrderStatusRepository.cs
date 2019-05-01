using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
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