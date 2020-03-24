using Optivem.Framework.Core.Application;
using Optivem.Northwind.Core.Application.Suppliers.Requests;
using Optivem.Northwind.Core.Application.Suppliers.Responses;
using Optivem.Northwind.Core.Domain.Suppliers.Entities;
using Optivem.Northwind.Core.Domain.Suppliers.Repositories;
using Optivem.Northwind.Core.Domain.Suppliers.ValueObjects;

namespace Optivem.Northwind.Core.Application.Suppliers.UseCases
{
    public class ListSuppliersUseCase : ListAggregatesUseCase<ISupplierRepository, ListSuppliersRequest, ListSuppliersResponse, ListSuppliersRecordResponse, Supplier, SupplierIdentity, int>
    {
        public ListSuppliersUseCase(ISupplierRepository repository, ICollectionResponseMapper<Supplier, ListSuppliersResponse> responseMapper) 
            : base(repository, responseMapper)
        {
        }
    }
}