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

		void Add(CustomerCustomerDemo customercustomerdemo);

		void Update(CustomerCustomerDemo customercustomerdemo);

		void Delete(CustomerCustomerDemo customercustomerdemo);

		bool Exists(string customerId, string customerTypeId);
	}
}
