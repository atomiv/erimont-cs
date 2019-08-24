﻿using Optivem.Framework.Core.Application;

namespace Optivem.Northwind.Core.Application.Products.Requests
{
    public class UpdateProductRequest : IRequest<int>
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
