using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

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

		public void Add(EmployeeTerritory employeeterritory)
		{
			repository.Add(employeeterritory);
		}

		public void Delete(EmployeeTerritory employeeterritory)
		{
			repository.Delete(employeeterritory);
		}

		public Task<IEnumerable<EmployeeTerritory>> GetAsync()
		{
			return repository.GetAsync();
		}

		public Task<EmployeeTerritory> GetAsync(string employeeId, string territoryId)
		{
			throw new NotImplementedException();

			// return repository.GetSingleOrDefaultAsync(id);
		}

		public void Update(EmployeeTerritory employeeterritory)
		{
			repository.Update(employeeterritory);
		}

		public bool Exists(string employeeId, string territoryId)
		{
			throw new NotImplementedException();

			// return repository.GetExists();
		}
	}
}
