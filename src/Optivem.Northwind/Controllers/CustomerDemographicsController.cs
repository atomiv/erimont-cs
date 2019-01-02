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
	[Route("api/customerDemographics")]
	[ApiController]
	public class CustomerDemographicsController : ControllerBase
	{
		private readonly INorthwindUnitOfWork unitOfWork;
		private readonly ICustomerDemographicService service;

		public CustomerDemographicsController(INorthwindUnitOfWork unitOfWork, ICustomerDemographicService service)
		{
			this.unitOfWork = unitOfWork;
			this.service = service;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<CustomerDemographic>>> GetCustomerDemographics()
		{
			var result = await service.GetAsync();
			return result.ToList();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<CustomerDemographic>> GetCustomerDemographic(string id)
		{
			var customerDemographic = await service.GetAsync(id);

			if (customerDemographic == null)
			{
				return NotFound();
			}

			return customerDemographic;
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> PutCustomerDemographic(string id, CustomerDemographic customerDemographic)
		{
			if (id != customerDemographic.CustomerTypeId)
			{
				return BadRequest();
			}

			try
			{
				service.Update(customerDemographic);

				await unitOfWork.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!service.Exists(id))
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
		public async Task<ActionResult<CustomerDemographic>> PostCustomerDemographic(CustomerDemographic customerDemographic)
		{
			service.Add(customerDemographic);

			await unitOfWork.SaveChangesAsync();

			return CreatedAtAction("GetCustomerDemographic", new { id = customerDemographic.CustomerTypeId }, customerDemographic);
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<CustomerDemographic>> DeleteCustomerDemographic(string id)
		{
			var customerDemographic = await service.GetAsync(id);

			if (customerDemographic == null)
			{
				return NotFound();
			}

			service.Delete(customerDemographic);

			await unitOfWork.SaveChangesAsync();

			return customerDemographic;
		}
	}
}
