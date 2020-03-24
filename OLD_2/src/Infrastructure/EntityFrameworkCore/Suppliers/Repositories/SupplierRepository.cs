using Optivem.Framework.Infrastructure.EntityFrameworkCore;
using Optivem.Northwind.Core.Domain.Suppliers.Entities;
using Optivem.Northwind.Core.Domain.Suppliers.Repositories;
using Optivem.Northwind.Core.Domain.Suppliers.ValueObjects;
using Optivem.Northwind.Infrastructure.EntityFrameworkCore.Suppliers.Records;

namespace Optivem.Northwind.Infrastructure.EntityFrameworkCore.Suppliers.Repositories
{
    public class SupplierRepository : Repository<DatabaseContext, Supplier, SupplierIdentity, SupplierRecord, int>, ISupplierRepository
    {
        public SupplierRepository(DatabaseContext context) : base(context)
        {
        }

        // TODO: VC: Perhaps make a SupplierFactory and a SupplierRecordFactory

        protected override Supplier GetAggregateRoot(SupplierRecord record)
        {
            var identity = new SupplierIdentity(record.Id);

            var company = record.Company;

            var address = new SupplierAddress(record.Address, 
                record.City, 
                record.StateProvince, 
                record.ZipPostalCode, 
                record.CountryRegion);

            var contactPerson = new SupplierContactPerson(record.FirstName, 
                record.LastName, 
                record.JobTitle);


            var contactDetails = new SupplierContactDetails(record.EmailAddress,
                record.BusinessPhone,
                record.HomePhone,
                record.MobilePhone,
                record.FaxNumber,
                record.WebPage);

            string notes = record.Notes;

            return new Supplier(identity, 
                company, 
                address, 
                contactPerson, 
                contactDetails, 
                notes);
        }

        protected override SupplierIdentity GetIdentity(SupplierRecord record)
        {
            return new SupplierIdentity(record.Id);
        }

        protected override SupplierRecord GetRecord(SupplierIdentity identity)
        {
            return new SupplierRecord
            {
                Id = identity.Id,
            };
        }

        // TODO: VC: Distinguishing between getting records for add vs update
        // TODO: VC: Should we use AutoMapper?

        protected override SupplierRecord GetRecord(Supplier aggregateRoot)
        {
            return new SupplierRecord
            {
                Id = aggregateRoot.Id.Id,
                Company = aggregateRoot.Company,
                LastName = aggregateRoot.ContactPerson.LastName,
                FirstName = aggregateRoot.ContactPerson.FirstName,
                EmailAddress = aggregateRoot.ContactDetails.EmailAddress,
                JobTitle = aggregateRoot.ContactPerson.JobTitle,
                BusinessPhone = aggregateRoot.ContactDetails.BusinessPhone,
                HomePhone = aggregateRoot.ContactDetails.HomePhone,
                MobilePhone = aggregateRoot.ContactDetails.MobilePhone,
                FaxNumber = aggregateRoot.ContactDetails.FaxNumber,
                Address = aggregateRoot.Address.Address,
                City = aggregateRoot.Address.City,
                StateProvince = aggregateRoot.Address.StateProvince,
                ZipPostalCode = aggregateRoot.Address.ZipPostalCode,
                CountryRegion = aggregateRoot.Address.CountryRegion,
                WebPage = aggregateRoot.ContactDetails.WebPage,
                Notes = aggregateRoot.Notes,
            };
        }
    }
}
