using Optivem.Framework.Core.Domain;

namespace Optivem.Northwind.Core.Domain.Orders.ValueObjects
{
    public class OrderDetailIdentity : Identity<int>
    {
        public OrderDetailIdentity(int id) 
            : base(id)
        {
        }
    }
}
