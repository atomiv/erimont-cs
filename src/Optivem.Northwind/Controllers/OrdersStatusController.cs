using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Optivem.Web.Rest.AspNetCore;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Application.Service;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Controllers
{
	[Route("api/orders-status")]
	[ApiController]
	public class OrdersStatusController : AspNetCoreCrudController<INorthwindUnitOfWork, IOrderStatusService, OrderStatusRequest, OrderStatusResponse, int>
	{
		public OrdersStatusController(INorthwindUnitOfWork unitOfWork, IOrderStatusService service)
			: base(unitOfWork, service, e => e.Id, e => e.Id)
		{
		}
	}
}
