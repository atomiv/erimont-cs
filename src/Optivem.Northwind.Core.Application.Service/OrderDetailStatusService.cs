using System.Collections.Generic;
using System.Threading.Tasks;
using Optivem.Infrastructure.Mapping;
using Optivem.Application.Service.Default;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Core.Application.Service
{
	public class OrderDetailStatusService : CrudService<IMappingService, INorthwindUnitOfWork, IOrderDetailStatusRepository, OrderDetailStatusRequest, OrderDetailStatusResponse, OrderDetailStatus, int>, IOrderDetailStatusService
	{
		public OrderDetailStatusService(IMappingService mappingService, INorthwindUnitOfWork unitOfWork)
			: base(mappingService, unitOfWork, uow => uow.OrderDetailStatusRepository)
		{

		}
	}
}
