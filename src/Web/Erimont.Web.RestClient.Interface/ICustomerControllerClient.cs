using Optivem.Atomiv.Core.Common.Http;
using Erimont.Core.Application.Customers.Commands;
using Erimont.Core.Application.Customers.Queries;
using System.Threading.Tasks;

namespace Erimont.Web.RestClient.Interface
{
    public interface ICustomerControllerClient : IHttpControllerClient
    {
        #region Commands

        Task<IObjectClientResponse<CreateCustomerCommandResponse>> CreateCustomerAsync(CreateCustomerCommand request);

        Task<IObjectClientResponse<DeleteCustomerCommandResponse>> DeleteCustomerAsync(DeleteCustomerCommand request);

        Task<IObjectClientResponse<EditCustomerCommandResponse>> EditCustomerAsync(EditCustomerCommand request);

        #endregion

        #region Queries

        Task<IObjectClientResponse<BrowseCustomersQueryResponse>> BrowseCustomersAsync(BrowseCustomersQuery request);

        Task<IObjectClientResponse<FilterCustomersQueryResponse>> FilterCustomersAsync(FilterCustomersQuery request);

        Task<IObjectClientResponse<ViewCustomerQueryResponse>> ViewCustomerAsync(ViewCustomerQuery request);

        #endregion
    }
}