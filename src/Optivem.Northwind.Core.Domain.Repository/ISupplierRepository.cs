using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Domain.Repository
{
    public interface ISupplierRepository : IRepository<Supplier, int>
    {

        // TODO: VC: DELETE

        /*

        Task<IEnumerable<Supplier>> GetAsync();

        Task<Supplier> GetAsync(int id);

        void Update(Supplier supplier);

        void Add(Supplier supplier);

        void Delete(Supplier supplier);

        bool GetExists(int id);
        
        */
    }
}
