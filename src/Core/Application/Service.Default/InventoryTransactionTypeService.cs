using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Framework.Core.Application.Services.Default;
using Optivem.Framework.Core.Common.Mapping;

namespace Optivem.Northwind.Core.Application.Services.Default
{
    public class InventoryTransactionTypeService : CrudService<IMappingService, INorthwindUnitOfWork, IInventoryTransactionTypeRepository, InventoryTransactionTypeRequest, InventoryTransactionTypeResponse, InventoryTransactionType, int>, IInventoryTransactionTypeService
    {
        public InventoryTransactionTypeService(IMappingService mappingService, INorthwindUnitOfWork unitOfWork)
            : base(mappingService, unitOfWork, uow => uow.InventoryTransactionTypeRepository)
        {
        }
    }
}