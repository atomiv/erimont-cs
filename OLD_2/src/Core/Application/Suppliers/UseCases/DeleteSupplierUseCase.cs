using Optivem.Framework.Core.Application;
using Optivem.Framework.Core.Domain;
using Optivem.Northwind.Core.Application.Suppliers.Requests;
using Optivem.Northwind.Core.Application.Suppliers.Responses;
using Optivem.Northwind.Core.Domain.Suppliers.Entities;
using Optivem.Northwind.Core.Domain.Suppliers.Repositories;
using Optivem.Northwind.Core.Domain.Suppliers.ValueObjects;

namespace Optivem.Northwind.Core.Application.Suppliers.UseCases
{
    public class DeleteSupplierUseCase : DeleteAggregateCase<ISupplierRepository, DeleteSupplierRequest, DeleteSupplierResponse, Supplier, SupplierIdentity, int>
    {
        public DeleteSupplierUseCase(IUnitOfWork unitOfWork, IIdentityFactory<SupplierIdentity, int> identityFactory) 
            : base(unitOfWork, identityFactory)
        {
        }
    }
}
