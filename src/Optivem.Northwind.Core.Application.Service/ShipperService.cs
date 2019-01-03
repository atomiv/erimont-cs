using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Core.Application.Service
{
	public class ShipperService : IShipperService
	{
		private INorthwindUnitOfWork unitOfWork;
		private IShipperRepository repository;

		public ShipperService(INorthwindUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
			this.repository = unitOfWork.ShipperRepository;
		}

		public void Add(Shipper shipper)
		{
			repository.Add(shipper);
		}

		public void Delete(Shipper shipper)
		{
			repository.Delete(shipper);
		}

		public Task<IEnumerable<Shipper>> GetAsync()
		{
			return repository.GetAsync();
		}

		public Task<Shipper> GetAsync(int id)
		{
			return repository.GetSingleOrDefaultAsync(id);
		}

		public void Update(Shipper shipper)
		{
			repository.Update(shipper);
		}

		public bool Exists(int id)
		{
			return repository.GetExists(id);
		}
	}
}
