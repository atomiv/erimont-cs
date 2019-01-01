using Optivem.Northwind.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Application.Service
{
	public interface IEmployeeService
	{
		Task<IEnumerable<Employee>> GetAsync();

		Task<Employee> GetAsync(int id);

		void Add(Employee employee);

		void Update(Employee employee);

		void Delete(Employee employee);

		bool Exists(int id);
	}
}
