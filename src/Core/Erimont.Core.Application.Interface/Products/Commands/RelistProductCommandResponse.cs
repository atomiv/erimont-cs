using System;

namespace Erimont.Core.Application.Products.Commands
{
    public class RelistProductCommandResponse
    {
        public Guid Id { get; set; }

        public bool IsListed { get; set; }
    }
}
