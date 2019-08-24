using Optivem.Northwind.Core.Application.UseCases;
using Optivem.Northwind.Core.Domain.Entities;
using Optivem.Northwind.Core.Domain.Repositories;
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