﻿using FluentAssertions;
using Erimont.Core.Domain.Products;
using System;
using Xunit;

namespace Erimont.Core.Domain.UnitTest.Products
{
    public class ProductUnitTest
    {
        [Fact]
        public void CanCreateValidProduct()
        {
            var identity = new ProductIdentity(Guid.NewGuid());
            var code = "ABC";
            var name = "My name";
            decimal price = 10.50m;
            var isListed = true;

            var product = new Product(identity, code, name, price, isListed);

            product.Id.Should().Be(identity);
            product.ProductCode.Should().Be(code);
            product.ProductName.Should().Be(name);
            product.ListPrice.Should().Be(price);
            product.IsListed.Should().Be(isListed);
        }
    }
}