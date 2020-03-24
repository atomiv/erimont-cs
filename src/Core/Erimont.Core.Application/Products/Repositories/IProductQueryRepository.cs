using Optivem.Atomiv.Core.Domain;
using Erimont.Core.Application.Products.Queries;
using System.Threading.Tasks;

namespace Erimont.Core.Application.Products.Repositories
{
    public interface IProductQueryRepository : IRepository
    {
        Task<BrowseProductsQueryResponse> QueryAsync(BrowseProductsQuery query);

        Task<FilterProductsQueryResponse> QueryAsync(FilterProductsQuery query);

        Task<ViewProductQueryResponse> QueryAsync(ViewProductQuery query);
    }
}
