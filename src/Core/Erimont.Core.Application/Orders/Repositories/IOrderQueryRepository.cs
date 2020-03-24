using Optivem.Atomiv.Core.Domain;
using Erimont.Core.Application.Orders.Queries;
using System.Threading.Tasks;

namespace Erimont.Core.Application.Orders.Repositories
{
    public interface IOrderQueryRepository : IRepository
    {
        Task<BrowseOrdersQueryResponse> QueryAsync(BrowseOrdersQuery query);

        Task<FilterOrdersQueryResponse> QueryAsync(FilterOrdersQuery query);

        Task<ViewOrderQueryResponse> QueryAsync(ViewOrderQuery query);
    }
}
