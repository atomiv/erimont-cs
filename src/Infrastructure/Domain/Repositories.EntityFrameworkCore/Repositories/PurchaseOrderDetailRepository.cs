using Optivem.Northwind.Core.Domain.Entities;
using Optivem.Northwind.Core.Domain.Repositories;
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