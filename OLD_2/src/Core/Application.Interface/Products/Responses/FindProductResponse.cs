﻿using Optivem.Framework.Core.Application;

namespace Optivem.Northwind.Core.Application.Products.Responses
{
    public class FindProductResponse : IResponse<int>
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
