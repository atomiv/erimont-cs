using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Framework.Infrastructure.Common.Mapping.AutoMapper;

namespace Optivem.Northwind.Infrastructure.Application.Mapping.AutoMapper
{
    public class OrderDetailRequestMapping : AutoMapperRequestProfile<OrderDetailRequest, OrderDetail>
    {
    }
}