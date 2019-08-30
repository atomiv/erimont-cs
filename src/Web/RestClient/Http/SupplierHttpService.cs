using Optivem.Framework.Core.Common.Http;
using Optivem.Framework.Infrastructure.AspNetCore;
using Optivem.Northwind.Core.Application.Suppliers.Requests;
using Optivem.Northwind.Core.Application.Suppliers.Responses;
using Optivem.Northwind.Web.RestClient.Interface;
using System.Threading.Tasks;

namespace Optivem.Northwind.Web.RestClient.Http
{
    public class SupplierHttpService : BaseControllerClient, ISupplierHttpService
    {
        public SupplierHttpService(IControllerClientFactory clientFactory)
            : base(clientFactory, "api/suppliers")
        {
        }

        public Task<IObjectClientResponse<CreateSupplierResponse>> CreateSupplierAsync(CreateSupplierRequest request)
        {
            return Client.PostAsync<CreateSupplierRequest, CreateSupplierResponse>(request);
        }

        public Task<IObjectClientResponse<DeleteSupplierResponse>> DeleteSupplierAsync(DeleteSupplierRequest request)
        {
            var id = request.Id;
            return Client.DeleteByIdAsync<int, DeleteSupplierResponse>(id);
        }

        public Task<IObjectClientResponse<FindSupplierResponse>> FindSupplierAsync(FindSupplierRequest request)
        {
            var id = request.Id;
            return Client.GetByIdAsync<int, FindSupplierResponse>(id);
        }

        public Task<IObjectClientResponse<ListSuppliersResponse>> ListSuppliersAsync(ListSuppliersRequest request)
        {
            return Client.GetAsync<ListSuppliersResponse>();
        }

        public Task<IObjectClientResponse<UpdateSupplierResponse>> UpdateSupplierAsync(UpdateSupplierRequest request)
        {
            return Client.PutByIdAsync<int, UpdateSupplierRequest, UpdateSupplierResponse>(request.Id, request);
        }
    }
}
