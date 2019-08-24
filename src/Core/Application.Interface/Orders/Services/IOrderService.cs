﻿using Optivem.Northwind.Core.Application.Orders.Requests;
using Optivem.Northwind.Core.Application.Orders.Responses;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Application.Orders.Services
{
    public interface IOrderService
    {
        Task<ArchiveOrderResponse> ArchiveOrderAsync(ArchiveOrderRequest request);

        Task<BrowseOrdersResponse> BrowseOrdersAsync(BrowseOrdersRequest request);

        Task<CancelOrderResponse> CancelOrderAsync(CancelOrderRequest request);

        Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest request);

        Task<FindOrderResponse> FindOrderAsync(FindOrderRequest request);

        Task<ListOrdersResponse> ListOrdersAsync(ListOrdersRequest request);

        Task<SubmitOrderResponse> SubmitOrderAsync(SubmitOrderRequest request);

        Task<UpdateOrderResponse> UpdateOrderAsync(UpdateOrderRequest request);
    }
}
