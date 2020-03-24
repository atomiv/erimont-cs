using Optivem.Framework.Core.Domain;

namespace Optivem.Northwind.Core.Domain.Orders.ValueObjects
{
    public class OrderIdentity : Identity<int>
    {
        public OrderIdentity(int id) : base(id)
        {
        }
    }
}
