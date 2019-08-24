using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Optivem.Framework.Web.AspNetCore.RazorPages;
using Optivem.Northwind.Web.UI.Models;
using Optivem.Northwind.Web.UI.Services.Interfaces;

namespace Optivem.Northwind.Web.UI.Pages.Customers
{
    public class IndexModel : PageServiceModel<ICustomerPageService>
    {
        public IndexModel(ICustomerPageService service) : base(service)
        {
        }

        public IList<Customer> Customers { get; set; }

        public async Task OnGet()
        {
            try
            {
                Customers = await Service.ListCustomers();
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}