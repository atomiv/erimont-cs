using Optivem.Northwind.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Application.Service
{
	public interface IEmployeeTerritoryService
	{
		Task<IEnumerable<EmployeeTerritory>> GetAsync();

		Task<EmployeeTerritory> GetAsync(int employeeId, string territoryId);

		void Add(EmployeeTerritory employeeTerritory);

		void Update(EmployeeTerritory employeeTerritory);

		void Delete(EmployeeTerritory employeeTerritory);

		bool Exists(int employeeId, string territoryId);
	}
}
