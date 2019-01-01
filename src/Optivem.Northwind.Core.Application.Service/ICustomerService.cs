using Optivem.Northwind.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Application.Service
{
	public interface ICustomerService
	{
		Task<IEnumerable<Customer>> GetAsync();

		Task<Customer> GetAsync(string id);

		void Add(Customer customer);

		void Update(Customer customer);

		void Delete(Customer customer);

		bool Exists(string id);
	}
}
