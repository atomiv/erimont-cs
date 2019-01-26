using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Optivem.Platform.Web.AspNetCore.Rest;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Application.Service;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Web.Rest.Controllers
{
	[Route("api/orders")]
	[ApiController]
	public class OrdersController : AspNetCoreCrudController<INorthwindUnitOfWork, IOrderService, OrderRequest, OrderResponse, int>
	{
		public OrdersController(INorthwindUnitOfWork unitOfWork, IOrderService service)
			: base(unitOfWork, service, e => e.Id, e => e.Id)
		{
		}
	}
}
