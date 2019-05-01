using Optivem.Northwind.Core.Application.Dtos;
using Optivem.Northwind.Core.Domain.Entities;
using Optivem.Northwind.Core.Domain.Repositories;
using Optivem.Framework.Core.Application.Services.Default;
using Optivem.Framework.Core.Common.Mapping;

namespace Optivem.Northwind.Core.Application.Services.Default
{
    public class OrderService : CrudService<IMappingService, INorthwindUnitOfWork, IOrderRepository, OrderRequest, OrderResponse, Order, int>, IOrderService
    {
        public OrderService(IMappingService mappingService, INorthwindUnitOfWork unitOfWork)
            : base(mappingService, unitOfWork, uow => uow.OrderRepository)
        {
        }
    }
}