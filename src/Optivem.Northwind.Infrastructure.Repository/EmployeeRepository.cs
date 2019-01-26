using Optivem.Platform.Infrastructure.Common.Repository.EntityFramework;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Infrastructure.Repository
{
	public class EmployeeRepository : EntityFrameworkRepository<NorthwindContext, Employee, int>, IEmployeeRepository
	{
		public EmployeeRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
