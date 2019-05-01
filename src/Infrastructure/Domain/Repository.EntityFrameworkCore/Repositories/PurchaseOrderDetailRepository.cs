using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Framework.Infrastructure.Domain.Repositories.EntityFrameworkCore;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore
{
    public class PurchaseOrderDetailRepository : EntityFrameworkRepository<NorthwindContext, PurchaseOrderDetail, int>, IPurchaseOrderDetailRepository
    {
        public PurchaseOrderDetailRepository(NorthwindContext context)
            : base(context)
        {
        }
    }
}