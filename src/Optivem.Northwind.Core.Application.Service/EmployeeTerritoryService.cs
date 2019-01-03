using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Application.Service
{
	public class EmployeeTerritoryService : IEmployeeTerritoryService
	{
		private INorthwindUnitOfWork unitOfWork;
		private IEmployeeTerritoryRepository repository;

		public EmployeeTerritoryService(INorthwindUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
			this.repository = unitOfWork.EmployeeTerritoryRepository;
		}

		public void Add(EmployeeTerritory employeeTerritory)
		{
			repository.Add(employeeTerritory);
		}

		public void Delete(EmployeeTerritory employeeTerritory)
		{
			repository.Delete(employeeTerritory);
		}

		public Task<IEnumerable<EmployeeTerritory>> GetAsync()
		{
			return repository.GetAsync();
		}

		public Task<EmployeeTerritory> GetAsync(int employeeId, string territoryId)
		{
			return repository.GetSingleOrDefaultAsync(employeeId, territoryId);
		}

		public void Update(EmployeeTerritory employeeTerritory)
		{
			repository.Update(employeeTerritory);
		}

		public bool Exists(int employeeId, string territoryId)
		{
			return repository.GetExists(employeeId, territoryId);
		}
	}
}
