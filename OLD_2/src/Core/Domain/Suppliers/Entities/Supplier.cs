using Optivem.Framework.Core.Domain;
using Optivem.Northwind.Core.Domain.Suppliers.ValueObjects;

namespace Optivem.Northwind.Core.Domain.Suppliers.Entities
{
    public class Supplier : AggregateRoot<SupplierIdentity>
    {
        public Supplier(SupplierIdentity id, 
            string company,
            SupplierAddress address,
            SupplierContactPerson contactPerson,
            SupplierContactDetails contactDetails,
            string notes) 
            : base(id)
        {
            Company = company;
            Address = address;
            ContactPerson = contactPerson;
            ContactDetails = contactDetails;
            Notes = notes;
        }

        public string Company { get; set; }

        public SupplierAddress Address { get; set; }

        public SupplierContactPerson ContactPerson { get; set; }

        public SupplierContactDetails ContactDetails { get; set; }

        public string Notes { get; set; }
    }
}
