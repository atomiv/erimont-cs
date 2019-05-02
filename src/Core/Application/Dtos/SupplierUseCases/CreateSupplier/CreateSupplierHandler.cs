using MediatR;
using Optivem.Framework.Core.Common.Mapping;
using Optivem.Northwind.Core.Domain.Entities;
using Optivem.Northwind.Core.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Optivem.Northwind.Core.Application.Dtos.SupplierUseCases.CreateSupplier
{
    public class CreateSupplierHandler : IRequestHandler<CreateSupplierRequest, CreateSupplierResponse> // : ICustomInteractor<CreateSupplierRequest, CreateSupplierResponse>
    {
        private INorthwindUnitOfWork _unitOfWork;
        private IMappingService _mappingService;

        public CreateSupplierHandler(INorthwindUnitOfWork unitOfWork, IMappingService mappingService)
        {
            _unitOfWork = unitOfWork;
            _mappingService = mappingService;
        }

        public async Task<CreateSupplierResponse> Handle(CreateSupplierRequest request, CancellationToken cancellationToken)
        {
            var entity = _mappingService.Map<CreateSupplierRequest, Supplier>(request);

            var repository = _unitOfWork.SupplierRepository;

            await repository.AddAsync(entity);

            await _unitOfWork.SaveChangesAsync();

            var response = _mappingService.Map<Supplier, CreateSupplierResponse>(entity);

            return response;
        }
    }
}
