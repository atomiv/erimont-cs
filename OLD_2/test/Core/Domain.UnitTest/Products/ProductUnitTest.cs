﻿using Optivem.Northwind.Core.Domain.Products.Entities;
using Optivem.Northwind.Core.Domain.Products.ValueObjects;
using Xunit;

namespace Optivem.Northwind.Core.Domain.UnitTest.Products
{
    public class ProductUnitTest
    {
        [Fact]
        public void Constructor_CanCreateValid()
        {
            var identity = new ProductIdentity(1);
            var code = "ABC";
            var name = "My name";
            decimal price = 10.50m;

            var product = new Product(identity, code, name, price);

            Assert.Equal(identity, product.Id);
            Assert.Equal(code, product.ProductCode);
            Assert.Equal(name, product.ProductName);
            Assert.Equal(price, product.ListPrice);
        }

        // TODO: VC: Cannot construct invalid etc
    }
}
