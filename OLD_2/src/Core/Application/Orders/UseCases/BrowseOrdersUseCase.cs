using Optivem.Framework.Core.Application;
using Optivem.Northwind.Core.Application.Orders.Requests;
using Optivem.Northwind.Core.Application.Orders.Responses;
using Optivem.Northwind.Core.Domain.Orders.Entities;
using Optivem.Northwind.Core.Domain.Orders.Repositories;
using Optivem.Northwind.Core.Domain.Orders.ValueObjects;

namespace Optivem.Northwind.Core.Application.Orders.UseCases
{
    public class BrowseOrdersUseCase : BrowseAggregatesUseCase<IOrderRepository, BrowseOrdersRequest, BrowseOrdersResponse, BrowseOrdersRecordResponse, Order, OrderIdentity, int>
    {
        public BrowseOrdersUseCase(IOrderRepository repository, ICollectionResponseMapper<Order, BrowseOrdersResponse> responseMapper) : base(repository, responseMapper)
        {
        }
    }
}
