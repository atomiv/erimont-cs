using System.Threading.Tasks;
using Optivem.Atomiv.Core.Application;
using Erimont.Core.Application.Products.Repositories;

namespace Erimont.Core.Application.Products.Queries
{
    public class FilterProductsQueryHandler : IRequestHandler<FilterProductsQuery, FilterProductsQueryResponse>
    {
        private readonly IProductQueryRepository _productReadRepository;

        public FilterProductsQueryHandler(IProductQueryRepository productReadRepository)
        {
            _productReadRepository = productReadRepository;
        }

        public Task<FilterProductsQueryResponse> HandleAsync(FilterProductsQuery request)
        {
            return _productReadRepository.QueryAsync(request);
        }
    }
}