using Optivem.Atomiv.Core.Domain;
using System;

namespace Erimont.Core.Domain.Orders
{
    public class OrderItemIdentity : Identity<Guid>
    {
        public OrderItemIdentity(Guid value)
            : base(value)
        {
        }
    }
}