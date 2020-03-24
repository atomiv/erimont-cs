using Optivem.Atomiv.Infrastructure.SequentialGuid;
using Erimont.Core.Domain.Orders;
using System;

namespace Erimont.Infrastructure.Persistence.IdentityGenerators
{
    public class OrderItemIdentityGenerator : IdentityGenerator<OrderItemIdentity>
    {
        protected override OrderItemIdentity Create(Guid guid)
        {
            return new OrderItemIdentity(guid);
        }
    }
}
