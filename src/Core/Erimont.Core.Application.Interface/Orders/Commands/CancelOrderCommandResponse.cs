using Erimont.Core.Common.Orders;
using System;

namespace Erimont.Core.Application.Orders.Commands
{
    public class CancelOrderCommandResponse
    {
        public Guid Id { get; set; }

        public OrderStatus Status { get; set; }
    }
}
