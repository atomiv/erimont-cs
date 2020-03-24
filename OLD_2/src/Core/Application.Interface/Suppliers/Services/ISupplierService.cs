using Optivem.Framework.Core.Application;
using Optivem.Northwind.Core.Application.Suppliers.Requests;
using Optivem.Northwind.Core.Application.Suppliers.Responses;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Application.Suppliers.Services
{
    public interface ISupplierService : IApplicationService
    {
        Task<CreateSupplierResponse> CreateSupplierAsync(CreateSupplierRequest request);

        Task<DeleteSupplierResponse> DeleteSupplierAsync(DeleteSupplierRequest request);

        Task<FindSupplierResponse> FindSupplierAsync(FindSupplierRequest request);

        Task<ListSuppliersResponse> ListSuppliersAsync(ListSuppliersRequest request);

        Task<UpdateSupplierResponse> UpdateSupplierAsync(UpdateSupplierRequest request);
    }
}
