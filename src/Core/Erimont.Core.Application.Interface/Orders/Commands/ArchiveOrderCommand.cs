using Optivem.Atomiv.Core.Application;
using System;

namespace Erimont.Core.Application.Orders.Commands
{
    public class ArchiveOrderCommand : IRequest<ArchiveOrderCommandResponse>
    {
        public Guid Id { get; set; }
    }
}