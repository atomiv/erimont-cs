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

			int employeeId = int.Parse(parts[0]);
			string territoryId = parts[1];

			var employeeTerritory = await service.GetAsync(employeeId, territoryId);

			if (employeeTerritory == null)
			{
				return NotFound();
			}

			return employeeTerritory;
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> PutEmployeeTerritory(string id, EmployeeTerritory employeeTerritory)
		{
			string[] parts = SplitId(id);

			int employeeId = int.Parse(parts[0]);
			string territoryId = parts[1];

			if (employeeId != employeeTerritory.EmployeeId || territoryId != employeeTerritory.TerritoryId)
			{
				return BadRequest();
			}

			try
			{
				service.Update(employeeTerritory);

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
		public async Task<ActionResult<EmployeeTerritory>> PostEmployeeTerritory(EmployeeTerritory employeeTerritory)
		{
			service.Add(employeeTerritory);

			await unitOfWork.SaveChangesAsync();

			string id = JoinId(employeeTerritory.EmployeeId.ToString(), employeeTerritory.TerritoryId);

			return CreatedAtAction("GetEmployeeTerritory", new { id = id }, employeeTerritory);
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<EmployeeTerritory>> DeleteEmployeeTerritory(string id)
		{
			string[] parts = SplitId(id);

			int employeeId = int.Parse(parts[0]);
			string territoryId = parts[1];

			var employeeTerritory = await service.GetAsync(employeeId, territoryId);

			if (employeeTerritory == null)
			{
				return NotFound();
			}

			service.Delete(employeeTerritory);

			await unitOfWork.SaveChangesAsync();

			return employeeTerritory;
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

