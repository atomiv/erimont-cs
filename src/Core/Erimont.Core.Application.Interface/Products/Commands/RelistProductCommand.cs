using Optivem.Atomiv.Core.Application;
using System;

namespace Erimont.Core.Application.Products.Commands
{
    public class RelistProductCommand : IRequest<RelistProductCommandResponse>
    {
        public Guid Id { get; set; }
    }
}