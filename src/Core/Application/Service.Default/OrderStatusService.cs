using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Platform.Core.Application.Service.Default;
using Optivem.Platform.Core.Common.Mapping;

namespace Optivem.Northwind.Core.Application.Service.Default
{
    public class OrderStatusService : CrudService<IMappingService, INorthwindUnitOfWork, IOrderStatusRepository, OrderStatusRequest, OrderStatusResponse, OrderStatus, int>, IOrderStatusService
    {
        public OrderStatusService(IMappingService mappingService, INorthwindUnitOfWork unitOfWork)
            : base(mappingService, unitOfWork, uow => uow.OrderStatusRepository)
        {
        }
    }
}