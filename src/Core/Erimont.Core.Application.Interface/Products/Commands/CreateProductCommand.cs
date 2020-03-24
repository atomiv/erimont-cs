﻿using Optivem.Atomiv.Core.Application;

namespace Erimont.Core.Application.Products.Commands
{
    public class CreateProductCommand : IRequest<CreateProductCommandResponse>
    {
        public string Code { get; set; }

        public string Description { get; set; }

        public decimal UnitPrice { get; set; }
    }
}