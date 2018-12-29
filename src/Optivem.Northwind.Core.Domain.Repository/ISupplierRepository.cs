using Optivem.Northwind.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Domain.Repository
{
    public interface ISupplierRepository
    {
        Task<IEnumerable<Supplier>> GetAsync();

        Task<Supplier> GetAsync(int id);

        void Update(Supplier supplier);

        void Add(Supplier supplier);

        void Delete(Supplier supplier);

        bool Exists(int id);
    }
}
