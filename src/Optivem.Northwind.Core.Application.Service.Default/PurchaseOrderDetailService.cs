using System.Collections.Generic;
using System.Threading.Tasks;
using Optivem.Platform.Core.Common.Mapping;
using Optivem.Platform.Core.Application.Service.Default;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Core.Application.Service.Default
{
	public class PurchaseOrderDetailService : CrudService<IMappingService, INorthwindUnitOfWork, IPurchaseOrderDetailRepository, PurchaseOrderDetailRequest, PurchaseOrderDetailResponse, PurchaseOrderDetail, int>, IPurchaseOrderDetailService
	{
		public PurchaseOrderDetailService(IMappingService mappingService, INorthwindUnitOfWork unitOfWork)
			: base(mappingService, unitOfWork, uow => uow.PurchaseOrderDetailRepository)
		{

		}
	}
}
