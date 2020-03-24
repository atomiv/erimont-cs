﻿using Optivem.Atomiv.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Erimont.Core.Domain.Products
{
    public interface IProductProviderService : IService
    {
        public Task<IEnumerable<Product>> GetProductsAsync();
    }
}
