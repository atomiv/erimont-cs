using Optivem.Atomiv.Core.Application;
using Erimont.Core.Application.Orders.Repositories;
using System.Threading.Tasks;

namespace Erimont.Core.Application.Orders.Queries
{
    public class FilterOrdersQueryHandler : IRequestHandler<FilterOrdersQuery, FilterOrdersQueryResponse>
    {
        private readonly IOrderQueryRepository _orderReadRepository;

        public FilterOrdersQueryHandler(IOrderQueryRepository orderReadRepository)
        {
            _orderReadRepository = orderReadRepository;
        }

        public Task<FilterOrdersQueryResponse> HandleAsync(FilterOrdersQuery request)
        {
            return _orderReadRepository.QueryAsync(request);
        }
    }
}