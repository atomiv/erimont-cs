using System.Collections.Generic;
using System.Threading.Tasks;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Core.Application.Service
{
    public class CustomerService : ICustomerService
	{
		private INorthwindUnitOfWork unitOfWork;
		private ICustomerRepository repository;

		public CustomerService(INorthwindUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
			this.repository = unitOfWork.CustomerRepository;
		}

		public void Add(Customer customer)
		{
			repository.Add(customer);
		}

		public void Delete(Customer customer)
		{
			repository.Delete(customer);
		}

		public Task<IEnumerable<Customer>> GetAsync()
		{
			return repository.GetAsync();
		}

		public Task<Customer> GetAsync(string id)
		{
			return repository.GetSingleOrDefaultAsync(id);
		}

		public void Update(Customer customer)
		{
			repository.Update(customer);
		}

		public bool Exists(string id)
		{
			return repository.GetExists(id);
		}
	}
}
