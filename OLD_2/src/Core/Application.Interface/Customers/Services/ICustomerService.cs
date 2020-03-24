using Optivem.Framework.Core.Application;
using Optivem.Northwind.Core.Application.Customers.Requests;
using Optivem.Northwind.Core.Application.Customers.Responses;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Application.Customers.Services
{
    public interface ICustomerService : IApplicationService
    {
        Task<BrowseCustomersResponse> BrowseCustomersAsync(BrowseCustomersRequest request);

        Task<CreateCustomerResponse> CreateCustomerAsync(CreateCustomerRequest request);

        Task<DeleteCustomerResponse> DeleteCustomerAsync(DeleteCustomerRequest request);

        Task<FindCustomerResponse> FindCustomerAsync(FindCustomerRequest request);

        Task<ListCustomersResponse> ListCustomersAsync(ListCustomersRequest request);

        Task<UpdateCustomerResponse> UpdateCustomerAsync(UpdateCustomerRequest request);
    }
}