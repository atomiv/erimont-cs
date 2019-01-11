using System.Collections.Generic;
using System.Threading.Tasks;
using Optivem.Commons.Mapping;
using Optivem.Commons.Service.Default;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Core.Application.Service
{
	public class PurchaseOrderService : CrudService<IMappingService, INorthwindUnitOfWork, IPurchaseOrderRepository, PurchaseOrderRequest, PurchaseOrderResponse, PurchaseOrder, int>, IPurchaseOrderService
	{
		public PurchaseOrderService(IMappingService mappingService, INorthwindUnitOfWork unitOfWork)
			: base(mappingService, unitOfWork, uow => uow.PurchaseOrderRepository)
		{

		}
	}
}
