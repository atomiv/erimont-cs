using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Core.Application.Service
{
	public class CustomerDemographicService : ICustomerDemographicService
	{
		private INorthwindUnitOfWork unitOfWork;
		private ICustomerDemographicRepository repository;

		public CustomerDemographicService(INorthwindUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
			this.repository = unitOfWork.CustomerDemographicRepository;
		}

		public void Add(CustomerDemographic customerdemographic)
		{
			repository.Add(customerdemographic);
		}

		public void Delete(CustomerDemographic customerdemographic)
		{
			repository.Delete(customerdemographic);
		}

		public Task<IEnumerable<CustomerDemographic>> GetAsync()
		{
			return repository.GetAsync();
		}

		public Task<CustomerDemographic> GetAsync(string id)
		{
			return repository.GetSingleOrDefaultAsync(id);
		}

		public void Update(CustomerDemographic customerdemographic)
		{
			repository.Update(customerdemographic);
		}

		public bool Exists(string id)
		{
			return repository.GetExists(id);
		}
	}
}
