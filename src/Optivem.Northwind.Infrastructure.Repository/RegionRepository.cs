using Optivem.Commons.Persistence.EntityFramework;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Repository
{
    public class RegionRepository : EntityFrameworkRepository<NorthwindContext, Region, int>, IRegionRepository
	{
		public RegionRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
