using Optivem.Commons.Persistence.EntityFramework;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Repository
{
	public class ShipperRepository : EntityFrameworkRepository<NorthwindContext, Shipper, int>, IShipperRepository
	{
		public ShipperRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
