using System.Collections.Generic;
using System.Threading.Tasks;
using Optivem.Infrastructure.Mapping;
using Optivem.Application.Service.Default;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Core.Application.Service
{
	public class InventoryTransactionService : CrudService<IMappingService, INorthwindUnitOfWork, IInventoryTransactionRepository, InventoryTransactionRequest, InventoryTransactionResponse, InventoryTransaction, int>, IInventoryTransactionService
	{
		public InventoryTransactionService(IMappingService mappingService, INorthwindUnitOfWork unitOfWork)
			: base(mappingService, unitOfWork, uow => uow.InventoryTransactionRepository)
		{

		}
	}
}
