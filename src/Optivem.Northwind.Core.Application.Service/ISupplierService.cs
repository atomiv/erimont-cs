using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Application.Service
{
    public interface ISupplierService
    {
        Task<IEnumerable<SupplierResponse>> GetAsync();

        Task<SupplierResponse> GetAsync(int id);

        SupplierResponse Add(SupplierRequest supplier);

        void Update(SupplierRequest supplier);

        void Delete(int id);

        bool Exists(int id);
    }
}
