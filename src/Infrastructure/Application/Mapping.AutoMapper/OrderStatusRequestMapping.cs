using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Platform.Infrastructure.Common.Mapping.AutoMapper;

namespace Optivem.Northwind.Infrastructure.Application.Mapping.AutoMapper
{
    public class OrderStatusRequestMapping : AutoMapperRequestProfile<OrderStatus, OrderStatusRequest>
    {
    }
}