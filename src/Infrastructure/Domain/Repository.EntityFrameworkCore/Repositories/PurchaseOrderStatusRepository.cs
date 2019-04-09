using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Platform.Infrastructure.Common.Repository.EntityFrameworkCore;

namespace Optivem.Northwind.Infrastructure.Domain.Repository.EntityFrameworkCore
{
    public class PurchaseOrderStatusRepository : EntityFrameworkRepository<NorthwindContext, PurchaseOrderStatus, int>, IPurchaseOrderStatusRepository
    {
        public PurchaseOrderStatusRepository(NorthwindContext context)
            : base(context)
        {
        }
    }
}