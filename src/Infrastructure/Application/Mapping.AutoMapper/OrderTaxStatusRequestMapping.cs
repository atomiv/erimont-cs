using Optivem.Northwind.Core.Application.Dtos;
using Optivem.Northwind.Core.Domain.Entities;
using Optivem.Framework.Infrastructure.Common.Mapping.AutoMapper;

namespace Optivem.Northwind.Infrastructure.Application.Mapping.AutoMapper
{
    public class OrderTaxStatusRequestMapping : AutoMapperRequestProfile<OrderTaxStatusRequest, OrderTaxStatus>
    {
    }
}