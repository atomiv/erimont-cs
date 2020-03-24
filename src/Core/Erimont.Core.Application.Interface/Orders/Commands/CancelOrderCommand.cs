using Optivem.Atomiv.Core.Application;
using System;

namespace Erimont.Core.Application.Orders.Commands
{
    public class CancelOrderCommand : IRequest<CancelOrderCommandResponse>
    {
        public Guid Id { get; set; }
    }
}