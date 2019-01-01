using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Core.Application.Service
{
    public class SupplierService : ISupplierService
    {
        private IMapper mapper;
        private INorthwindUnitOfWork unitOfWork;
        private ISupplierRepository repository;

        public SupplierService(IMapper mapper, INorthwindUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.repository = unitOfWork.SupplierRepository;
        }

        public SupplierResponse Add(SupplierRequest supplier)
        {
            var entity = mapper.Map<SupplierRequest, Supplier>(supplier);
            repository.Add(entity);
            unitOfWork.SaveChanges();
            var response = mapper.Map<Supplier, SupplierResponse>(entity);
            return response;
        }

        public void Delete(int id)
        {
            var entity = repository.GetSingleOrDefault(id);

            if(entity != null)
            {
                repository.Delete(entity);
            }
        }
        
        public async Task<IEnumerable<SupplierResponse>> GetAsync()
        {
            var entities = await repository.GetAsync();
            return mapper.Map<IEnumerable<Supplier>, IEnumerable<SupplierResponse>>(entities);
        }

        public async Task<SupplierResponse> GetAsync(int id)
        {
            var entity = await repository.GetSingleOrDefaultAsync(id);
            return mapper.Map<Supplier, SupplierResponse>(entity);
        }

        public void Update(SupplierRequest supplier)
        {
            var entity = mapper.Map<SupplierRequest, Supplier>(supplier);
            repository.Update(entity);
        }

        public bool Exists(int id)
        {
            return repository.GetExists(id);
        }
    }
}
