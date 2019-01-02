using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Core.Application.Service
{
	public class CustomerCustomerDemoService : ICustomerCustomerDemoService
	{
		private INorthwindUnitOfWork unitOfWork;
		private ICustomerCustomerDemoRepository repository;

		public CustomerCustomerDemoService(INorthwindUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
			this.repository = unitOfWork.CustomerCustomerDemoRepository;
		}

		public void Add(CustomerCustomerDemo customerCustomerDemo)
		{
			repository.Add(customerCustomerDemo);
		}

		public void Delete(CustomerCustomerDemo customerCustomerDemo)
		{
			repository.Delete(customerCustomerDemo);
		}

		public Task<IEnumerable<CustomerCustomerDemo>> GetAsync()
		{
			return repository.GetAsync();
		}

		public Task<CustomerCustomerDemo> GetAsync(string customerId, string customerTypeId)
		{
			return repository.GetSingleOrDefaultAsync(customerId, customerTypeId);
		}

		public void Update(CustomerCustomerDemo customerCustomerDemo)
		{
			repository.Update(customerCustomerDemo);
		}

		public bool Exists(string customerId, string customerTypeId)
		{
			return repository.GetExists(customerId, customerTypeId);
		}
	}
}
