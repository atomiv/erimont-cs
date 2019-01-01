using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Commons.Persistence.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Optivem.Commons.Persistence;

namespace Optivem.Northwind.Core.Domain.Repository
{
	public interface ICustomerDemographicRepository : IRepository<CustomerDemographic, string>
	{

	}
}
