using Optivem.Commons.Persistence;
using Optivem.Northwind.Core.Domain.Entity;

namespace Optivem.Northwind.Core.Domain.Repository
{
    // TODO: JC: Current database id is string type, later change back to int

    public interface ICustomerRepository : IRepository<Customer, string>
	{

	}
}
