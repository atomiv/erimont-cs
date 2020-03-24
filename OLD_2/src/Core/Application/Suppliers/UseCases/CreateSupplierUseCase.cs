using Optivem.Framework.Core.Application;
using Optivem.Framework.Core.Domain;
using Optivem.Northwind.Core.Application.Suppliers.Requests;
using Optivem.Northwind.Core.Application.Suppliers.Responses;
using Optivem.Northwind.Core.Domain.Suppliers.Entities;
using Optivem.Northwind.Core.Domain.Suppliers.Repositories;
using Optivem.Northwind.Core.Domain.Suppliers.ValueObjects;

namespace Optivem.Northwind.Core.Application.Suppliers.UseCases
{
    public class CreateSupplierUseCase : CreateAggregateUseCase<ISupplierRepository, CreateSupplierRequest, CreateSupplierResponse, Supplier, SupplierIdentity, int>
    {
        public CreateSupplierUseCase(IUnitOfWork unitOfWork, IResponseMapper<Supplier, CreateSupplierResponse> responseMapper)
            : base(unitOfWork, responseMapper)
        {
        }

        // TODO: VC: Check possibiluty of factory, and then it will be internally able to also set the id

        protected override Supplier CreateAggregateRoot(Supplier aggregateRoot, SupplierIdentity identity)
        {
            return new Supplier(identity, 
                aggregateRoot.Company, 
                aggregateRoot.Address, 
                aggregateRoot.ContactPerson, 
                aggregateRoot.ContactDetails, 
                aggregateRoot.Notes);
        }

        protected override Supplier CreateAggregateRoot(CreateSupplierRequest request)
        {
            var identity = SupplierIdentity.Null;

            var company = request.Company;

            var address = new SupplierAddress(request.Address,
                request.City,
                request.StateProvince,
                request.ZipPostalCode,
                request.CountryRegion);

            var contactPerson = new SupplierContactPerson(request.FirstName,
                request.LastName,
                request.JobTitle);


            var contactDetails = new SupplierContactDetails(request.EmailAddress,
                request.BusinessPhone,
                request.HomePhone,
                request.MobilePhone,
                request.FaxNumber,
                request.WebPage);

            string notes = request.Notes;

            return new Supplier(identity,
                company,
                address,
                contactPerson,
                contactDetails,
                notes);
        }
    }
}