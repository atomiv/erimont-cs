using Optivem.Framework.Core.Domain;

namespace Optivem.Northwind.Core.Domain.Suppliers.ValueObjects
{
    public class SupplierIdentity : Identity<int>
    {
        public static readonly SupplierIdentity Null = new SupplierIdentity(0);

        public SupplierIdentity(int id) : base(id)
        {
        }
    }
}
