using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Framework.Core.Application.Services.Default;
using Optivem.Framework.Core.Common.Mapping;

namespace Optivem.Northwind.Core.Application.Services.Default
{
    public class EmployeePrivilegeService : CrudService<IMappingService, INorthwindUnitOfWork, IEmployeePrivilegeRepository, EmployeePrivilegeRequest, EmployeePrivilegeResponse, EmployeePrivilege, int>, IEmployeePrivilegeService
    {
        public EmployeePrivilegeService(IMappingService mappingService, INorthwindUnitOfWork unitOfWork)
            : base(mappingService, unitOfWork, uow => uow.EmployeePrivilegeRepository)
        {
        }
    }
}