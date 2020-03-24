using Optivem.Atomiv.Core.Domain;
using Erimont.Core.Application.Customers.Queries;
using System.Threading.Tasks;

namespace Erimont.Core.Application.Customers.Repositories
{
    // TODO: VC: Base read repository, not related to domain
    public interface ICustomerQueryRepository : IRepository
    {
        Task<BrowseCustomersQueryResponse> QueryAsync(BrowseCustomersQuery query);

        Task<FilterCustomersQueryResponse> QueryAsync(FilterCustomersQuery query);

        Task<ViewCustomerQueryResponse> QueryAsync(ViewCustomerQuery query);
    }
}
