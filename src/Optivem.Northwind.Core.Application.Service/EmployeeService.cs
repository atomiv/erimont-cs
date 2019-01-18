using System.Collections.Generic;
using System.Threading.Tasks;
using Optivem.Infrastructure.Mapping;
using Optivem.Application.Service.Default;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Core.Application.Service
{
	public class EmployeeService : CrudService<IMappingService, INorthwindUnitOfWork, IEmployeeRepository, EmployeeRequest, EmployeeResponse, Employee, int>, IEmployeeService
	{
		public EmployeeService(IMappingService mappingService, INorthwindUnitOfWork unitOfWork)
			: base(mappingService, unitOfWork, uow => uow.EmployeeRepository)
		{

		}
	}
}
