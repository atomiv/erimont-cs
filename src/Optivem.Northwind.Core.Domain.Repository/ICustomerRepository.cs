using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Domain.Repository
{
	// TODO: JC: Current database id is string type, later change back to int

	public interface ICustomerRepository : IRepository<Customer, string>
	{

	}
}
