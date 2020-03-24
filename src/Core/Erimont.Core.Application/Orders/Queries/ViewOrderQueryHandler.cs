using System.Threading.Tasks;
using Optivem.Atomiv.Core.Application;
using Erimont.Core.Application.Orders.Repositories;

namespace Erimont.Core.Application.Orders.Queries
{
    public class ViewOrderQueryHandler : IRequestHandler<ViewOrderQuery, ViewOrderQueryResponse>
    {
        private readonly IOrderQueryRepository _orderReadRepository;

        public ViewOrderQueryHandler(IMapper mapper, IOrderQueryRepository orderReadRepository)
        {
            _orderReadRepository = orderReadRepository;
        }

        public async Task<ViewOrderQueryResponse> HandleAsync(ViewOrderQuery request)
        {
            var response = await _orderReadRepository.QueryAsync(request);

            return response;
        }
    }
}