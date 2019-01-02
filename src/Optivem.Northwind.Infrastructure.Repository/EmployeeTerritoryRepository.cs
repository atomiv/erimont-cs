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
	public class EmployeeTerritoryRepository : EntityFrameworkRepository<NorthwindContext, EmployeeTerritory, string>, IEmployeeTerritoryRepository
	{
		public EmployeeTerritoryRepository(NorthwindContext context)
			: base(context)
		{
		}
	}
}
