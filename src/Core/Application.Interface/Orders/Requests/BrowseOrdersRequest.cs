﻿using Optivem.Framework.Core.Application;

namespace Optivem.Northwind.Core.Application.Orders.Requests
{
    public class BrowseOrdersRequest : ICollectionRequest
    {
        public int Page { get; set; }

        public int Size { get; set; }
    }
}
