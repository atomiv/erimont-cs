using Optivem.Northwind.Core.Domain.Entities;
using Optivem.Northwind.Core.Domain.Repositories;
using Optivem.Framework.Infrastructure.Domain.Repositories.EntityFrameworkCore;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore
{
    public class SupplierRepository : EntityFrameworkRepository<NorthwindContext, Supplier, int>, ISupplierRepository
    {
        public SupplierRepository(NorthwindContext context)
            : base(context)
        {
        }
    }
}