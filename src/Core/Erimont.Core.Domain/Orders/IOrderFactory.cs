using Optivem.Atomiv.Core.Domain;
using Erimont.Core.Domain.Customers;
using Erimont.Core.Domain.Products;
using System.Collections.Generic;

namespace Erimont.Core.Domain.Orders
{
    public interface IOrderFactory : IFactory
    {
        Order CreateNewOrder(CustomerIdentity customerId, IEnumerable<OrderItem> orderItems);

        OrderItem CreateNewOrderItem(ProductIdentity productId, decimal unitPrice, int quantity);
    }
}
