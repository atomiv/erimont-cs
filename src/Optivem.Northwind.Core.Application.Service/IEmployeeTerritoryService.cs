using Optivem.Northwind.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Application.Service
{
	public interface IEmployeeTerritoryService
	{
		Task<IEnumerable<EmployeeTerritory>> GetAsync();

		Task<EmployeeTerritory> GetAsync(string employeeId, string territoryId);

		void Add(EmployeeTerritory employeeterritory);

		void Update(EmployeeTerritory employeeterritory);

		void Delete(EmployeeTerritory employeeterritory);

		bool Exists(string employeeId, string territoryId);
	}
}
