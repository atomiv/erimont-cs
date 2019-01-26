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

namespace Optivem.Northwind.Controllers
{
	[Route("api/inventory-transactions")]
	[ApiController]
	public class InventoryTransactionsController : AspNetCoreCrudController<INorthwindUnitOfWork, IInventoryTransactionService, InventoryTransactionRequest, InventoryTransactionResponse, int>
	{
		public InventoryTransactionsController(INorthwindUnitOfWork unitOfWork, IInventoryTransactionService service)
			: base(unitOfWork, service, e => e.Id, e => e.Id)
		{
		}
	}
}
