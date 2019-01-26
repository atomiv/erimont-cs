using Optivem.Platform.Infrastructure.Common.Repository.EntityFramework;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Domain.Repository
{
	public class EmployeePrivilegeRepository : EntityFrameworkRepository<NorthwindContext, EmployeePrivilege, int>, IEmployeePrivilegeRepository
	{
		public EmployeePrivilegeRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
