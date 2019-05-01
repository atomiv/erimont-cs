﻿using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Framework.Core.Application.Services.Default;
using Optivem.Framework.Core.Common.Mapping;

namespace Optivem.Northwind.Core.Application.Services.Default
{
    public class PurchaseOrderService : CrudService<IMappingService, INorthwindUnitOfWork, IPurchaseOrderRepository, PurchaseOrderRequest, PurchaseOrderResponse, PurchaseOrder, int>, IPurchaseOrderService
    {
        public PurchaseOrderService(IMappingService mappingService, INorthwindUnitOfWork unitOfWork)
            : base(mappingService, unitOfWork, uow => uow.PurchaseOrderRepository)
        {
        }
    }
}