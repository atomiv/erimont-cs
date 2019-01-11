using Optivem.Commons.Persistence.EntityFramework;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Repository
{
	public class PrivilegeRepository : EntityFrameworkRepository<NorthwindContext, Privilege, int>, IPrivilegeRepository
	{
		public PrivilegeRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
