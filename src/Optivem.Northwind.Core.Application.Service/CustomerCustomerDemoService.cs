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

		public void Add(CustomerCustomerDemo customercustomerdemo)
		{
			repository.Add(customercustomerdemo);
		}

		public void Delete(CustomerCustomerDemo customercustomerdemo)
		{
			repository.Delete(customercustomerdemo);
		}

		public Task<IEnumerable<CustomerCustomerDemo>> GetAsync()
		{
			return repository.GetAsync();
		}

		public Task<CustomerCustomerDemo> GetAsync(string customerId, string customerTypeId)
		{
			return repository.GetSingleOrDefaultAsync(customerId, customerTypeId);
		}

		public void Update(CustomerCustomerDemo customercustomerdemo)
		{
			repository.Update(customercustomerdemo);
		}

		public bool Exists(string customerId, string customerTypeId)
		{
			var id = new string[] { customerId, customerTypeId };
			return repository.GetExists(id);
		}
	}
}
