using Optivem.Framework.Core.Application;
using Optivem.Northwind.Core.Application.Orders.Requests;
using Optivem.Northwind.Core.Application.Orders.Responses;
using Optivem.Northwind.Core.Domain.Orders.Entities;
using Optivem.Northwind.Core.Domain.Orders.Repositories;
using Optivem.Northwind.Core.Domain.Orders.ValueObjects;

namespace Optivem.Northwind.Core.Application.Orders.UseCases
{
    public class ListOrdersUseCase : ListAggregatesUseCase<IOrderRepository, ListOrdersRequest, ListOrdersResponse, ListOrdersRecordResponse, Order, OrderIdentity, int>
    {
        public ListOrdersUseCase(IOrderRepository repository, ICollectionResponseMapper<Order, ListOrdersResponse> responseMapper) : base(repository, responseMapper)
        {
        }
    }
}
