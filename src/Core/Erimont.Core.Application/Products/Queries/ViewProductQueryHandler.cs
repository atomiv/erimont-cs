using System.Threading.Tasks;
using Optivem.Atomiv.Core.Application;
using Erimont.Core.Application.Products.Repositories;

namespace Erimont.Core.Application.Products.Queries
{
    public class ViewProductQueryHandler : IRequestHandler<ViewProductQuery, ViewProductQueryResponse>
    {
        private readonly IProductQueryRepository _productReadRepository;

        public ViewProductQueryHandler(IProductQueryRepository productReadRepository)
        {
            _productReadRepository = productReadRepository;
        }

        public async Task<ViewProductQueryResponse> HandleAsync(ViewProductQuery request)
        {
            var response = await _productReadRepository.QueryAsync(request);

            return response;
        }
    }
}