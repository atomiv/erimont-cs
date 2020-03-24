using Optivem.Atomiv.Core.Application;

namespace Erimont.Core.Application.Customers.Queries
{
    public class FilterCustomersQuery : IRequest<FilterCustomersQueryResponse>
    {
        public int Limit { get; set; }

        public string NameSearch { get; set; }
    }
}