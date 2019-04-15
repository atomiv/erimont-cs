using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Web.AspNetCore.Rest.Test.Base;
using System.Collections.Generic;

namespace Optivem.Northwind.Web.AspNetCore.Rest.Test.Seeders
{
    public class SupplierSeeder : BaseSeeder<Supplier>
    {
        protected override List<Supplier> Create()
        {
            var supplier1 = new Supplier
            {
                Id = 0,
                Address = "dds",
                BusinessPhone = "fffs",
                City = "sfsfsf",
                Company = "sdfsfs",
                HomePhone = "sffsfs",
                FaxNumber = "sfsfssf",
                CountryRegion = "sffsgklf",
                EmailAddress = "sffss",
                FirstName = "sfsf",
                JobTitle = "sffssf",
                LastName = "wrrw",
                MobilePhone = "sffgssgs",
                Notes = "jkjhkjhfs",
                PurchaseOrder = null,
                StateProvince = "afffsf",
                WebPage = "ooeqeio",
                ZipPostalCode = "adad",
            };

            return new List<Supplier>
            {
                supplier1,
            };
        }
    }
}
