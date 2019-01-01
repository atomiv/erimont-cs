using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Optivem.Northwind.Core.Application.Service;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;

namespace Optivem.Northwind.Controllers
{
    [Route("api/customers")]
	[ApiController]
	public class CustomersController : ControllerBase
	{
		private readonly INorthwindUnitOfWork unitOfWork;
		private readonly ICustomerService service;

		public CustomersController(INorthwindUnitOfWork unitOfWork, ICustomerService service)
		{
			this.unitOfWork = unitOfWork;
			this.service = service;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
		{
			var result = await service.GetAsync();
			return result.ToList();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Customer>> GetCustomer(string id)
		{
			var customer = await service.GetAsync(id);

			if (customer == null)
			{
				return NotFound();
			}

			return customer;
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> PutCustomer(string id, Customer customer)
		{
			if (id != customer.CustomerId)
			{
				return BadRequest();
			}

			try
			{
				service.Update(customer);

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
		public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
		{
			service.Add(customer);

			await unitOfWork.SaveChangesAsync();

			return CreatedAtAction("GetCustomer", new { id = customer.CustomerId }, customer);
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<Customer>> DeleteCustomer(string id)
		{
			var customer = await service.GetAsync(id);

			if (customer == null)
			{
				return NotFound();
			}

			service.Delete(customer);

			await unitOfWork.SaveChangesAsync();

			return customer;
		}
	}
}
