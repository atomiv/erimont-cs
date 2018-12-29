using Microsoft.EntityFrameworkCore;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Repository.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optivem.Northwind.Infrastructure.Repository
{
    // TODO: VC: EntityFrameworkRepository<Supplier, int>, 

    public class SupplierRepository : EntityFrameworkRepository<Supplier, int, NorthwindContext>, ISupplierRepository
    {
        public SupplierRepository(NorthwindContext context) 
            : base(context)
        {
        }


        // TODO: VC: DELETE

        /*

        private readonly NorthwindContext context;

        public SupplierRepository(NorthwindContext context)
        {
            this.context = context;
        }

        public void Add(Supplier supplier)
        {
            context.Suppliers.Add(supplier);
        }

        public void Delete(Supplier supplier)
        {
            context.Suppliers.Remove(supplier);
        }

        public bool GetExists(int id)
        {
            return context.Suppliers.Any(e => e.SupplierId == id);
        }

        public async Task<IEnumerable<Supplier>> GetAsync()
        {
            return await context.Suppliers.ToListAsync();
        }

        public Task<Supplier> GetAsync(int id)
        {
            return context.Suppliers.FindAsync(id);
        }

        public void Update(Supplier supplier)
        {
            context.Entry(supplier).State = EntityState.Modified;
        }

        */

    }
}
