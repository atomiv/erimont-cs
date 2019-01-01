using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Core.Application.Service
{
	public class EmployeeService : IEmployeeService
	{
		private INorthwindUnitOfWork unitOfWork;
		private IEmployeeRepository repository;

		public EmployeeService(INorthwindUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
			this.repository = unitOfWork.EmployeeRepository;
		}

		public void Add(Employee employee)
		{
			repository.Add(employee);
		}

		public void Delete(Employee employee)
		{
			repository.Delete(employee);
		}

		public Task<IEnumerable<Employee>> GetAsync()
		{
			return repository.GetAsync();
		}

		public Task<Employee> GetAsync(int id)
		{
			return repository.GetSingleOrDefaultAsync(id);
		}

		public void Update(Employee employee)
		{
			repository.Update(employee);
		}

		public bool Exists(int id)
		{
			return repository.GetExists(id);
		}
	}
}
