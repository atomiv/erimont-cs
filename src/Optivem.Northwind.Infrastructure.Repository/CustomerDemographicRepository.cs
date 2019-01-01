using Microsoft.EntityFrameworkCore;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Commons.Persistence.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optivem.Northwind.Infrastructure.Repository
{
	public class CustomerDemographicRepository : EntityFrameworkRepository<NorthwindContext, CustomerDemographic, string>, ICustomerDemographicRepository
	{
		public CustomerDemographicRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
