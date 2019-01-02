using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Core.Application.Service
{
	public class TerritoryService : ITerritoryService
	{
		private INorthwindUnitOfWork unitOfWork;
		private ITerritoryRepository repository;

		public TerritoryService(INorthwindUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
			this.repository = unitOfWork.TerritoryRepository;
		}

		public void Add(Territory territory)
		{
			repository.Add(territory);
		}

		public void Delete(Territory territory)
		{
			repository.Delete(territory);
		}

		public Task<IEnumerable<Territory>> GetAsync()
		{
			return repository.GetAsync();
		}

		public Task<Territory> GetAsync(string id)
		{
			return repository.GetSingleOrDefaultAsync(id);
		}

		public void Update(Territory territory)
		{
			repository.Update(territory);
		}

		public bool Exists(string id)
		{
			return repository.GetExists(id);
		}
	}
}
