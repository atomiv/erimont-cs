using Optivem.Framework.Core.Domain;
using Optivem.Northwind.Core.Domain.Suppliers.ValueObjects;

namespace Optivem.Northwind.Core.Domain.Suppliers.Factories
{
    public class SupplierIdentityFactory : IIdentityFactory<SupplierIdentity, int>
    {
        public SupplierIdentity Create(int id)
        {
            return new SupplierIdentity(id);
        }
    }
}
