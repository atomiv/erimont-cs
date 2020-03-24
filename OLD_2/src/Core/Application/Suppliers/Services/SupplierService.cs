using Optivem.Framework.Core.Application;
using Optivem.Framework.Core.Application.Services;
using Optivem.Northwind.Core.Application.Suppliers.Requests;
using Optivem.Northwind.Core.Application.Suppliers.Responses;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Application.Suppliers.Services
{
    public class SupplierService : BaseService, ISupplierService
    {
        public SupplierService(IRequestHandler requestHandler)
            : base(requestHandler)
        {
        }

        public Task<CreateSupplierResponse> CreateSupplierAsync(CreateSupplierRequest request)
        {
            return HandleAsync<CreateSupplierRequest, CreateSupplierResponse>(request);
        }

        public Task<DeleteSupplierResponse> DeleteSupplierAsync(DeleteSupplierRequest request)
        {
            return HandleAsync<DeleteSupplierRequest, DeleteSupplierResponse>(request);
        }

        public Task<FindSupplierResponse> FindSupplierAsync(FindSupplierRequest request)
        {
            return HandleAsync<FindSupplierRequest, FindSupplierResponse>(request);
        }

        public Task<ListSuppliersResponse> ListSuppliersAsync(ListSuppliersRequest request)
        {
            return HandleAsync<ListSuppliersRequest, ListSuppliersResponse>(request);
        }

        public Task<UpdateSupplierResponse> UpdateSupplierAsync(UpdateSupplierRequest request)
        {
            return HandleAsync<UpdateSupplierRequest, UpdateSupplierResponse>(request);
        }
    }
}
