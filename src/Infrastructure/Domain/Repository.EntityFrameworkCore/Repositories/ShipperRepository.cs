using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Framework.Infrastructure.Domain.Repositories.EntityFrameworkCore;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore
{
    public class ShipperRepository : EntityFrameworkRepository<NorthwindContext, Shipper, int>, IShipperRepository
    {
        public ShipperRepository(NorthwindContext context)
            : base(context)
        {
        }
    }
}