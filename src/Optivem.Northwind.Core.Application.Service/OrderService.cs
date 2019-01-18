using System.Collections.Generic;
using System.Threading.Tasks;
using Optivem.Infrastructure.Mapping;
using Optivem.Application.Service.Default;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Core.Application.Service
{
	public class OrderService : CrudService<IMappingService, INorthwindUnitOfWork, IOrderRepository, OrderRequest, OrderResponse, Order, int>, IOrderService
	{
		public OrderService(IMappingService mappingService, INorthwindUnitOfWork unitOfWork)
			: base(mappingService, unitOfWork, uow => uow.OrderRepository)
		{

		}
	}
}
