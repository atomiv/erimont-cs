using Optivem.Framework.Infrastructure.AspNetCore;
using Optivem.Northwind.Core.Application.Suppliers.Requests;
using Optivem.Northwind.Core.Application.Suppliers.Responses;
using Optivem.Northwind.Core.Application.Suppliers.Services;
using Optivem.Northwind.Web.RestClient.Interface;
using System.Threading.Tasks;

namespace Optivem.Northwind.Web.RestClient
{
    public class SupplierService : BaseHttpService<ISupplierHttpService>, ISupplierService
    {
        public SupplierService(ISupplierHttpService service)
            : base(service)
        {
        }

        public Task<CreateSupplierResponse> CreateSupplierAsync(CreateSupplierRequest request)
        {
            return ExecuteAsync(e => e.CreateSupplierAsync(request));
        }

        public Task<DeleteSupplierResponse> DeleteSupplierAsync(DeleteSupplierRequest request)
        {
            return ExecuteAsync(e => e.DeleteSupplierAsync(request));
        }

        public Task<FindSupplierResponse> FindSupplierAsync(FindSupplierRequest request)
        {
            return ExecuteAsync(e => e.FindSupplierAsync(request));
        }

        public Task<ListSuppliersResponse> ListSuppliersAsync(ListSuppliersRequest request)
        {
            return ExecuteAsync(e => e.ListSuppliersAsync(request));
        }

        public Task<UpdateSupplierResponse> UpdateSupplierAsync(UpdateSupplierRequest request)
        {
            return ExecuteAsync(e => e.UpdateSupplierAsync(request));
        }

        // TODO: VC: Create base HttpService class with this method and with holding the service, also for DI
    }
}
