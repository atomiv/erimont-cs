﻿using Optivem.Framework.Core.Application;

namespace Optivem.Northwind.Core.Application.Products.Requests
{
    public class CreateProductRequest : IRequest
    {
        public string Code { get; set; }

        public string Description { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
