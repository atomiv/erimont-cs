using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Optivem.Northwind.Core.Application.Service;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Northwind.Infrastructure.Repository;

namespace Optivem.Northwind.Controllers
{
	[Route("api/customercustomerdemos")]
	[ApiController]
	public class CustomerCustomerDemosController : ControllerBase
	{
		private readonly INorthwindUnitOfWork unitOfWork;
		private readonly ICustomerCustomerDemoService service;

		public CustomerCustomerDemosController(INorthwindUnitOfWork unitOfWork, ICustomerCustomerDemoService service)
		{
			this.unitOfWork = unitOfWork;
			this.service = service;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<CustomerCustomerDemo>>> GetCustomerCustomerDemos()
		{
			var result = await service.GetAsync();
			return result.ToList();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<CustomerCustomerDemo>> GetCustomerCustomerDemo(string id)
		{
			string[] parts = SplitId(id);

			string customerId = parts[0];
			string customerTypeId = parts[1];

			var customercustomerdemo = await service.GetAsync(customerId, customerTypeId);

			if (customercustomerdemo == null)
			{
				return NotFound();
			}

			return customercustomerdemo;
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> PutCustomerCustomerDemo(string id, CustomerCustomerDemo customercustomerdemo)
		{
			string[] parts = SplitId(id);

			string customerId = parts[0];
			string customerTypeId = parts[1];

			if (customerId != customercustomerdemo.CustomerId || customerTypeId != customercustomerdemo.CustomerTypeId)
			{
				return BadRequest();
			}

			try
			{
				service.Update(customercustomerdemo);

				await unitOfWork.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!service.Exists(customerId, customerTypeId))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return NoContent();
		}

		[HttpPost]
		public async Task<ActionResult<CustomerCustomerDemo>> PostCustomerCustomerDemo(CustomerCustomerDemo customercustomerdemo)
		{
			service.Add(customercustomerdemo);

			await unitOfWork.SaveChangesAsync();

			string id = JoinId(customercustomerdemo.CustomerId, customercustomerdemo.CustomerTypeId);

			return CreatedAtAction("GetCustomerCustomerDemo", new { id = id }, customercustomerdemo);
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<CustomerCustomerDemo>> DeleteCustomerCustomerDemo(string id)
		{
			string[] parts = SplitId(id);

			string customerId = parts[0];
			string customerTypeId = parts[1];

			var customercustomerdemo = await service.GetAsync(customerId, customerTypeId);

			if (customercustomerdemo == null)
			{
				return NotFound();
			}

			service.Delete(customercustomerdemo);

			await unitOfWork.SaveChangesAsync();

			return customercustomerdemo;
		}

		private string[] SplitId(string id)
		{
			string[] parts = id.Split("-");
			return parts;
		}

		private string JoinId(params string[] parts)
		{
			return string.Join("-", parts);
		}
	}
}
