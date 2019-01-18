using System.Collections.Generic;
using System.Threading.Tasks;
using Optivem.Infrastructure.Mapping;
using Optivem.Application.Service.Default;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Core.Application.Service
{
	public class EmployeePrivilegeService : CrudService<IMappingService, INorthwindUnitOfWork, IEmployeePrivilegeRepository, EmployeePrivilegeRequest, EmployeePrivilegeResponse, EmployeePrivilege, int>, IEmployeePrivilegeService
	{
		public EmployeePrivilegeService(IMappingService mappingService, INorthwindUnitOfWork unitOfWork)
			: base(mappingService, unitOfWork, uow => uow.EmployeePrivilegeRepository)
		{

		}
	}
}
