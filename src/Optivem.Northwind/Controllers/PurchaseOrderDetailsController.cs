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
	[Route("api/purchase-order-details")]
	[ApiController]
	public class PurchaseOrderDetailsController : AspNetCoreCrudController<INorthwindUnitOfWork, IPurchaseOrderDetailService, PurchaseOrderDetailRequest, PurchaseOrderDetailResponse, int>
	{
		public PurchaseOrderDetailsController(INorthwindUnitOfWork unitOfWork, IPurchaseOrderDetailService service)
			: base(unitOfWork, service, e => e.Id, e => e.Id)
		{
		}
	}
}
