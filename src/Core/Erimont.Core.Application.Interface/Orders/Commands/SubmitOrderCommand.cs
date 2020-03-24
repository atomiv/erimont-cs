using Optivem.Atomiv.Core.Application;
using System;

namespace Erimont.Core.Application.Orders.Commands
{
    public class SubmitOrderCommand : IRequest<SubmitOrderCommandResponse>
    {
        public Guid Id { get; set; }
    }
}