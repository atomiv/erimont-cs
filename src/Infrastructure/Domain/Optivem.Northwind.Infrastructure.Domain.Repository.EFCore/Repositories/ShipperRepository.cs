using Optivem.Platform.Infrastructure.Common.Repository.EntityFramework;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

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
