using Optivem.Atomiv.Core.Application;
using Erimont.Core.Application.Products.Repositories;
using System.Threading.Tasks;

namespace Erimont.Core.Application.Products.Queries
{
    public class BrowseProductsQueryHandler : IRequestHandler<BrowseProductsQuery, BrowseProductsQueryResponse>
    {
        private readonly IProductQueryRepository _productReadRepository;

        public BrowseProductsQueryHandler(IProductQueryRepository productReadRepository)
        {
            _productReadRepository = productReadRepository;
        }

        public Task<BrowseProductsQueryResponse> HandleAsync(BrowseProductsQuery request)
        {
            return _productReadRepository.QueryAsync(request);
        }
    }
}