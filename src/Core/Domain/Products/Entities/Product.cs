﻿using Optivem.Framework.Core.Domain;
using Optivem.Northwind.Core.Domain.Products.ValueObjects;

namespace Optivem.Northwind.Core.Domain.Products.Entities
{
    public class Product : AggregateRoot<ProductIdentity>
    {
        public Product(ProductIdentity id, string productCode, string productName, decimal listPrice)
            : base(id)
        {
            ProductCode = productCode;
            ProductName = productName;
            ListPrice = listPrice;
        }

        public string ProductCode { get; set; }

        public string ProductName { get; set; }

        public decimal ListPrice { get; set; }
    }
}