using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Platform.Infrastructure.Common.Repository.EntityFrameworkCore;

namespace Optivem.Northwind.Infrastructure.Domain.Repository.EntityFrameworkCore
{
    public class ShipperRepository : EntityFrameworkRepository<NorthwindContext, Shipper, int>, IShipperRepository
    {
        public ShipperRepository(NorthwindContext context)
            : base(context)
        {
        }
    }
}