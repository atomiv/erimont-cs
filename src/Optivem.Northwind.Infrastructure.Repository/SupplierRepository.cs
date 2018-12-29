using Microsoft.EntityFrameworkCore;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optivem.Northwind.Infrastructure.Repository
{
    public class SupplierRepository : ISupplierRepository
    {
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

        public bool Exists(int id)
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

    }
}
