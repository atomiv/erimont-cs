using Optivem.Infrastructure.Repository;
using Optivem.Northwind.Core.Domain.Entity;

namespace Optivem.Northwind.Core.Domain.Repository
{
	public interface IEmployeeRepository : IRepository<Employee, int>
	{

	}
}
