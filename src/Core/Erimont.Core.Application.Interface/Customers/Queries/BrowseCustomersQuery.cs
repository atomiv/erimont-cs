using Optivem.Atomiv.Core.Application;

namespace Erimont.Core.Application.Customers.Queries
{
    public class BrowseCustomersQuery : IRequest<BrowseCustomersQueryResponse>
    {
        public int Page { get; set; }

        public int Size { get; set; }
    }
}