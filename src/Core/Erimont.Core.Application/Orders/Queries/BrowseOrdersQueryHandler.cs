﻿using Optivem.Atomiv.Core.Application;
using Erimont.Core.Application.Orders.Repositories;
using System.Threading.Tasks;

namespace Erimont.Core.Application.Orders.Queries
{
    public class BrowseOrdersQueryHandler : IRequestHandler<BrowseOrdersQuery, BrowseOrdersQueryResponse>
    {
        private readonly IOrderQueryRepository _orderReadRepository;

        public BrowseOrdersQueryHandler(IOrderQueryRepository orderReadRepository)
        {
            _orderReadRepository = orderReadRepository;
        }

        public Task<BrowseOrdersQueryResponse> HandleAsync(BrowseOrdersQuery request)
        {
            return _orderReadRepository.QueryAsync(request);
        }
    }
}