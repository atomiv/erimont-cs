using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Core.Application.Service
{
    public class SupplierService : ISupplierService
    {
        private INorthwindUnitOfWork unitOfWork;
        private ISupplierRepository repository;

        public SupplierService(INorthwindUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.repository = unitOfWork.SupplierRepository;
        }

        public void Add(Supplier supplier)
        {
            repository.Add(supplier);
        }

        public void Delete(Supplier supplier)
        {
            repository.Delete(supplier);
        }
        
        public Task<IEnumerable<Supplier>> GetAsync()
        {
            return repository.GetAsync();
        }

        public Task<Supplier> GetAsync(int id)
        {
            return repository.GetSingleOrDefaultAsync(id);
        }

        public void Update(Supplier supplier)
        {
            repository.Update(supplier);
        }

        public bool Exists(int id)
        {
            return repository.GetExists(id);
        }
    }
}
