using System.Collections.Generic;
using System.Threading.Tasks;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Core.Application.Service
{
    public class RegionService : IRegionService
	{
		private INorthwindUnitOfWork unitOfWork;
		private IRegionRepository repository;

		public RegionService(INorthwindUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
			this.repository = unitOfWork.RegionRepository;
		}

		public void Add(Region region)
		{
			repository.Add(region);
		}

		public void Delete(Region region)
		{
			repository.Delete(region);
		}

		public Task<IEnumerable<Region>> GetAsync()
		{
			return repository.GetAsync();
		}

		public Task<Region> GetAsync(int id)
		{
			return repository.GetSingleOrDefaultAsync(id);
		}

		public void Update(Region region)
		{
			repository.Update(region);
		}

		public bool Exists(int id)
		{
			return repository.GetExists(id);
		}
	}
}
