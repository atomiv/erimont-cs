using Optivem.Framework.Core.Application;
using Optivem.Framework.Core.Domain;
using Optivem.Northwind.Core.Application.Suppliers.Requests;
using Optivem.Northwind.Core.Application.Suppliers.Responses;
using Optivem.Northwind.Core.Domain.Suppliers.Entities;
using Optivem.Northwind.Core.Domain.Suppliers.Repositories;
using Optivem.Northwind.Core.Domain.Suppliers.ValueObjects;

namespace Optivem.Northwind.Core.Application.Suppliers.UseCases
{
    // TODO: VC: Perhaps have shared responses?

    public class UpdateSupplierUseCase : UpdateAggregateUseCase<ISupplierRepository, UpdateSupplierRequest, UpdateSupplierResponse, Supplier, SupplierIdentity, int>
    {
        public UpdateSupplierUseCase(IUnitOfWork unitOfWork, IResponseMapper responseMapper) 
            : base(unitOfWork, responseMapper)
        {
        }

        protected override SupplierIdentity GetIdentity(int id)
        {
            return new SupplierIdentity(id);
        }

        protected override void Update(Supplier aggregateRoot, UpdateSupplierRequest request)
        {
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


            aggregateRoot.Company = company;
            aggregateRoot.Address = address;
            aggregateRoot.ContactPerson = contactPerson;
            aggregateRoot.ContactDetails = contactDetails;
            aggregateRoot.Notes = notes;
        }
    }
}
