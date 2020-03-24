using Optivem.Framework.Core.Common.Http;
using Optivem.Northwind.Core.Application.Suppliers.Requests;
using Optivem.Northwind.Core.Application.Suppliers.Responses;
using System.Threading.Tasks;

namespace Optivem.Northwind.Web.RestClient.Interface
{
    public interface ISupplierHttpService : IHttpService
    {
        Task<IObjectClientResponse<CreateSupplierResponse>> CreateSupplierAsync(CreateSupplierRequest request);

        Task<IObjectClientResponse<DeleteSupplierResponse>> DeleteSupplierAsync(DeleteSupplierRequest request);

        Task<IObjectClientResponse<FindSupplierResponse>> FindSupplierAsync(FindSupplierRequest request);

        Task<IObjectClientResponse<ListSuppliersResponse>> ListSuppliersAsync(ListSuppliersRequest request);

        Task<IObjectClientResponse<UpdateSupplierResponse>> UpdateSupplierAsync(UpdateSupplierRequest request);
    }
}
