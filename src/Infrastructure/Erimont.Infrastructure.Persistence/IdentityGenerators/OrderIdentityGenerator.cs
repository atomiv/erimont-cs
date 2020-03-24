using Optivem.Atomiv.Infrastructure.SequentialGuid;
using Erimont.Core.Domain.Orders;
using System;

namespace Erimont.Infrastructure.Persistence.IdentityGenerators
{
    public class OrderIdentityGenerator : IdentityGenerator<OrderIdentity>
    {
        protected override OrderIdentity Create(Guid guid)
        {
            return new OrderIdentity(guid);
        }
    }
}
