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
	[Route("api/employeeterritories")]
	[ApiController]
	public class EmployeeTerritoriesController : ControllerBase
	{
		private readonly INorthwindUnitOfWork unitOfWork;
		private readonly IEmployeeTerritoryService service;

		public EmployeeTerritoriesController(INorthwindUnitOfWork unitOfWork, IEmployeeTerritoryService service)
		{
			this.unitOfWork = unitOfWork;
			this.service = service;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<EmployeeTerritory>>> GetEmployeeTerritories()
		{
			var result = await service.GetAsync();
			return result.ToList();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<EmployeeTerritory>> GetEmployeeTerritory(string id)
		{
			string[] parts = SplitId(id);

			string employeeId = parts[0];
			string territoryId = parts[1];

			var employeeterritory = await service.GetAsync(employeeId, territoryId);

			if (employeeterritory == null)
			{
				return NotFound();
			}

			return employeeterritory;
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> PutEmployeeTerritory(string id, EmployeeTerritory employeeterritory)
		{
			string[] parts = SplitId(id);

			string employeeId = parts[0];
			string territoryId = parts[1];

			if (employeeId != employeeterritory.EmployeeId.ToString() || territoryId != employeeterritory.TerritoryId)
			{
				return BadRequest();
			}

			try
			{
				service.Update(employeeterritory);

				await unitOfWork.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!service.Exists(employeeId, territoryId))
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
		public async Task<ActionResult<EmployeeTerritory>> PostEmployeeTerritory(EmployeeTerritory employeeterritory)
		{
			service.Add(employeeterritory);

			await unitOfWork.SaveChangesAsync();

			string id = JoinId(employeeterritory.EmployeeId.ToString(), employeeterritory.TerritoryId);

			return CreatedAtAction("GetEmployeeTerritory", new { id = id }, employeeterritory);
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<EmployeeTerritory>> DeleteEmployeeTerritory(string id)
		{
			string[] parts = SplitId(id);

			string employeeId = parts[0];
			string territoryId = parts[1];

			var employeeterritory = await service.GetAsync(employeeId, territoryId);

			if (employeeterritory == null)
			{
				return NotFound();
			}

			service.Delete(employeeterritory);

			await unitOfWork.SaveChangesAsync();

			return employeeterritory;
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

