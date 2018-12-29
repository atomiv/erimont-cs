using Optivem.Northwind.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Application.Service
{
    public interface ISupplierService
    {
        Task<IEnumerable<Supplier>> GetAsync();

        Task<Supplier> GetAsync(int id);

        void Add(Supplier supplier);

        void Update(Supplier supplier);

        void Delete(Supplier supplier);

        bool Exists(int id);
    }
}
