﻿using Optivem.Framework.Core.Application;

namespace Optivem.Northwind.Core.Application.Products.Requests
{
    public class BrowseProductsRequest : ICollectionRequest
    {
        public int Page { get; set; }

        public int Size { get; set; }
    }
}
