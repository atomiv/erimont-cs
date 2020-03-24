using System.Threading.Tasks;
using Optivem.Atomiv.Core.Application;
using Erimont.Core.Application.Customers.Repositories;

namespace Erimont.Core.Application.Customers.Queries
{
    public class BrowseCustomersQueryHandler : IRequestHandler<BrowseCustomersQuery, BrowseCustomersQueryResponse>
    {
        private readonly ICustomerQueryRepository _customerReadRepository;

        public BrowseCustomersQueryHandler(ICustomerQueryRepository customerReadRepository)
        {
            _customerReadRepository = customerReadRepository;
        }

        public Task<BrowseCustomersQueryResponse> HandleAsync(BrowseCustomersQuery request)
        {
            return _customerReadRepository.QueryAsync(request);
        }
    }
}