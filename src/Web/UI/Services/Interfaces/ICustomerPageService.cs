﻿using Optivem.Framework.Web.AspNetCore.RazorPages;
using Optivem.Northwind.Web.UI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Optivem.Northwind.Web.UI.Services.Interfaces
{
    public interface ICustomerPageService : IPageService
    {
        Task<IList<Customer>> ListCustomers();

        Task CreateCustomer(Customer customer);
    }
}
