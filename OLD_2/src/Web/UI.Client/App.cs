﻿using Optivem.Framework.Infrastructure.Selenium;
using Optivem.Northwind.Web.UI.Client.Interface;
using Optivem.Northwind.Web.UI.Client.Interface.Pages;
using Optivem.Northwind.Web.UI.Client.Pages;

namespace Optivem.Northwind.Web.UI.Client
{
    public class App : App<CreateCustomerPage>, IApp
    {
        public App(Driver finder, string url) : base(finder)
        {
            Url = url;
        }

        public string Url { get; }

        public ICreateCustomerPage NavigateToCreateCustomerPage()
        {
            return new CreateCustomerPage(Url, Finder, true);
        }
    }
}
