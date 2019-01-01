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
	[Route("api/customerdemographics")]
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
			var customerdemographic = await service.GetAsync(id);

			if (customerdemographic == null)
			{
				return NotFound();
			}

			return customerdemographic;
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> PutCustomerDemographic(string id, CustomerDemographic customerdemographic)
		{
			if (id != customerdemographic.CustomerTypeId)
			{
				return BadRequest();
			}

			try
			{
				service.Update(customerdemographic);

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
		public async Task<ActionResult<CustomerDemographic>> PostCustomerDemographic(CustomerDemographic customerdemographic)
		{
			service.Add(customerdemographic);

			await unitOfWork.SaveChangesAsync();

			return CreatedAtAction("GetCustomerDemographic", new { id = customerdemographic.CustomerTypeId }, customerdemographic);
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<CustomerDemographic>> DeleteCustomerDemographic(string id)
		{
			var customerdemographic = await service.GetAsync(id);

			if (customerdemographic == null)
			{
				return NotFound();
			}

			service.Delete(customerdemographic);

			await unitOfWork.SaveChangesAsync();

			return customerdemographic;
		}
	}
}
