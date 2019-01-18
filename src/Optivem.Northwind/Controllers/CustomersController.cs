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
	[Route("api/customers")]
	[ApiController]
	public class CustomersController : AspNetCoreCrudController<INorthwindUnitOfWork, ICustomerService, CustomerRequest, CustomerResponse, int>
	{
		public CustomersController(INorthwindUnitOfWork unitOfWork, ICustomerService service)
			: base(unitOfWork, service, e => e.Id, e => e.Id)
		{
		}
	}
}
