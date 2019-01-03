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
	[Route("api/shippers")]
	[ApiController]
	public class ShippersController : ControllerBase
	{
		private readonly INorthwindUnitOfWork unitOfWork;
		private readonly IShipperService service;

		public ShippersController(INorthwindUnitOfWork unitOfWork, IShipperService service)
		{
			this.unitOfWork = unitOfWork;
			this.service = service;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Shipper>>> GetShippers()
		{
			var result = await service.GetAsync();
			return result.ToList();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Shipper>> GetShipper(int id)
		{
			var shipper = await service.GetAsync(id);

			if (shipper == null)
			{
				return NotFound();
			}

			return shipper;
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> PutShipper(int id, Shipper shipper)
		{
			if (id != shipper.ShipperId)
			{
				return BadRequest();
			}

			try
			{
				service.Update(shipper);

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
		public async Task<ActionResult<Shipper>> PostShipper(Shipper shipper)
		{
			service.Add(shipper);

			await unitOfWork.SaveChangesAsync();

			return CreatedAtAction("GetShipper", new { id = shipper.ShipperId }, shipper);
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<Shipper>> DeleteShipper(int id)
		{
			var shipper = await service.GetAsync(id);

			if (shipper == null)
			{
				return NotFound();
			}

			service.Delete(shipper);

			await unitOfWork.SaveChangesAsync();

			return shipper;
		}
	}
}
