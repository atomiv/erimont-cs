using Optivem.Framework.Core.Application;
using Optivem.Framework.Core.Domain;
using Optivem.Northwind.Core.Application.Suppliers.Requests;
using Optivem.Northwind.Core.Application.Suppliers.Responses;
using Optivem.Northwind.Core.Domain.Suppliers.Entities;
using Optivem.Northwind.Core.Domain.Suppliers.Repositories;
using Optivem.Northwind.Core.Domain.Suppliers.ValueObjects;

namespace Optivem.Northwind.Core.Application.Suppliers.UseCases
{
    public class FindSupplierUseCase : FindAggregateUseCase<ISupplierRepository, FindSupplierRequest, FindSupplierResponse, Supplier, SupplierIdentity, int>
    {
        public FindSupplierUseCase(IUnitOfWork unitOfWork, IResponseMapper responseMapper)
            : base(unitOfWork, responseMapper)
        {
        }

        // TODO: VC: Common factory, optional, unless reflection --> i.e. virtual
        protected override SupplierIdentity GetIdentity(int id)
        {
            // TODO: VC: Do this via reflection
            return new SupplierIdentity(id);
        }
    }
}