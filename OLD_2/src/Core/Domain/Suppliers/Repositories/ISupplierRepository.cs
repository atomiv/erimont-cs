using Optivem.Framework.Core.Domain;
using Optivem.Northwind.Core.Domain.Suppliers.Entities;
using Optivem.Northwind.Core.Domain.Suppliers.ValueObjects;

namespace Optivem.Northwind.Core.Domain.Suppliers.Repositories
{
    public interface ISupplierRepository : ICrudRepository<Supplier, SupplierIdentity>
    {
    }
}
