﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Optivem.Commons.Mapping;
using Optivem.Commons.Service.Default;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Core.Application.Service
{
	public class InventoryTransactionTypeService : CrudService<IMappingService, INorthwindUnitOfWork, IInventoryTransactionTypeRepository, InventoryTransactionTypeRequest, InventoryTransactionTypeResponse, InventoryTransactionType, int>, IInventoryTransactionTypeService
	{
		public InventoryTransactionTypeService(IMappingService mappingService, INorthwindUnitOfWork unitOfWork)
			: base(mappingService, unitOfWork, uow => uow.InventoryTransactionTypeRepository)
		{

		}
	}
}