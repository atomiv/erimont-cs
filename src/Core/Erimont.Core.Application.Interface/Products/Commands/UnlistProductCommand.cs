using Optivem.Atomiv.Core.Application;
using System;

namespace Erimont.Core.Application.Products.Commands
{
    public class UnlistProductCommand : IRequest<UnlistProductCommandResponse>
    {
        public Guid Id { get; set; }
    }
}