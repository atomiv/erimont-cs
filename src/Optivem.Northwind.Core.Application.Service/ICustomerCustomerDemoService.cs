using Optivem.Northwind.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Application.Service
{
	public interface ICustomerCustomerDemoService
	{
		Task<IEnumerable<CustomerCustomerDemo>> GetAsync();

		Task<CustomerCustomerDemo> GetAsync(string customerId, string customerTypeId);

		void Add(CustomerCustomerDemo customerCustomerDemo);

		void Update(CustomerCustomerDemo customerCustomerDemo);

		void Delete(CustomerCustomerDemo customerCustomerDemo);

		bool Exists(string customerId, string customerTypeId);
	}
}
