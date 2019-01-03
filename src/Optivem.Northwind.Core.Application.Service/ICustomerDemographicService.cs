using Optivem.Northwind.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Application.Service
{
	public interface ICustomerDemographicService
	{
		Task<IEnumerable<CustomerDemographic>> GetAsync();

		Task<CustomerDemographic> GetAsync(string id);

		void Add(CustomerDemographic customerDemographic);

		void Update(CustomerDemographic customerDemographic);

		void Delete(CustomerDemographic customerDemographic);

		bool Exists(string id);
	}
}
