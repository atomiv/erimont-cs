using Microsoft.EntityFrameworkCore;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Repository.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optivem.Northwind.Infrastructure.Repository
{
	public class CustomerCustomerDemoRepository : EntityFrameworkRepository<NorthwindContext, CustomerCustomerDemo, string[]>, ICustomerCustomerDemoRepository
	{
		public CustomerCustomerDemoRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
