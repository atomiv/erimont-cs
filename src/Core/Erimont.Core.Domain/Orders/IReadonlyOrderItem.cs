using Optivem.Atomiv.Core.Domain;
using Erimont.Core.Common.Orders;
using Erimont.Core.Domain.Products;

namespace Erimont.Core.Domain.Orders
{
    public interface IReadonlyOrderItem : IReadonlyEntity<OrderItemIdentity>
    {
        ProductIdentity ProductId { get; }

        int Quantity { get; }

        decimal UnitPrice { get; }

        OrderItemStatus Status { get; }
    }
}
