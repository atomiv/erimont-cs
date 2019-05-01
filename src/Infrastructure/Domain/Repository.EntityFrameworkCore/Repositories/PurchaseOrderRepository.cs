using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Framework.Infrastructure.Domain.Repositories.EntityFrameworkCore;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore
{
    public class PurchaseOrderRepository : EntityFrameworkRepository<NorthwindContext, PurchaseOrder, int>, IPurchaseOrderRepository
    {
        public PurchaseOrderRepository(NorthwindContext context)
            : base(context)
        {
        }
    }
}