﻿using Optivem.Framework.Core.Application;

namespace Optivem.Northwind.Core.Application.Customers.Responses
{
    public class FindCustomerResponse : IResponse<int>
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}