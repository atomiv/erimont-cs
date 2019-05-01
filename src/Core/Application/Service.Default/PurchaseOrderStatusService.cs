using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Framework.Core.Application.Services.Default;
using Optivem.Framework.Core.Common.Mapping;

namespace Optivem.Northwind.Core.Application.Services.Default
{
    public class PurchaseOrderStatusService : CrudService<IMappingService, INorthwindUnitOfWork, IPurchaseOrderStatusRepository, PurchaseOrderStatusRequest, PurchaseOrderStatusResponse, PurchaseOrderStatus, int>, IPurchaseOrderStatusService
    {
        public PurchaseOrderStatusService(IMappingService mappingService, INorthwindUnitOfWork unitOfWork)
            : base(mappingService, unitOfWork, uow => uow.PurchaseOrderStatusRepository)
        {
        }
    }
}