using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Platform.Core.Application.Service.Default;
using Optivem.Platform.Core.Common.Mapping;

namespace Optivem.Northwind.Core.Application.Service.Default
{
    public class PrivilegeService : CrudService<IMappingService, INorthwindUnitOfWork, IPrivilegeRepository, PrivilegeRequest, PrivilegeResponse, Privilege, int>, IPrivilegeService
    {
        public PrivilegeService(IMappingService mappingService, INorthwindUnitOfWork unitOfWork)
            : base(mappingService, unitOfWork, uow => uow.PrivilegeRepository)
        {
        }
    }
}