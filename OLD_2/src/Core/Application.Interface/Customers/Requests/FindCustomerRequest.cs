﻿using Optivem.Framework.Core.Application;

namespace Optivem.Northwind.Core.Application.Customers.Requests
{
    public class FindCustomerRequest : IRequest<int>
    {
        public int Id { get; set; }
    }
}