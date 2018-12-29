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
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        // TODO: VC: DELETE context

        // private readonly NorthwindContext context;

        private readonly INorthwindUnitOfWork unitOfWork;

        private readonly ISupplierService service;

        public SuppliersController(/* NorthwindContext context, */ INorthwindUnitOfWork unitOfWork, ISupplierService service)
        {
            // TODO: VC: DELETE

            // this.context = context;
            this.unitOfWork = unitOfWork;
            this.service = service;
        }

        // GET: api/Suppliers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Supplier>>> GetSuppliers()
        {
            // TODO: VC: DELETE
            // return await context.Suppliers.ToListAsync();

            var result = await service.GetAsync();
            return result.ToList();
        }

        // GET: api/Suppliers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Supplier>> GetSupplier(int id)
        {
            // TODO: VC: DELETE
            // var supplier = await context.Suppliers.FindAsync(id);

            var supplier = await service.GetAsync(id);

            if (supplier == null)
            {
                return NotFound();
            }

            return supplier;
        }

        // PUT: api/Suppliers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSuppliers(int id, Supplier supplier)
        {
            if (id != supplier.SupplierId)
            {
                return BadRequest();
            }

            // TODO: VC: DELETE


            /*
            context.Entry(supplier).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuppliersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            */

            service.Update(supplier);

            try
            {
                await unitOfWork.CommitAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuppliersExists(id))
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

        // POST: api/Suppliers
        [HttpPost]
        public async Task<ActionResult<Supplier>> PostSupplier(Supplier supplier)
        {
            // TODO: VC: DELETE

            // context.Suppliers.Add(supplier);
            // await context.SaveChangesAsync();

            service.Add(supplier);
            await unitOfWork.CommitAsync();


            return CreatedAtAction("GetSupplier", new { id = supplier.SupplierId }, supplier);
        }

        // DELETE: api/Suppliers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Supplier>> DeleteSupplier(int id)
        {
            // TODO: VC: DELETE
            
            /*
            var supplier = await context.Suppliers.FindAsync(id);
            if (supplier == null)
            {
                return NotFound();
            }

            context.Suppliers.Remove(supplier);
            await context.SaveChangesAsync();
            */
            
            var supplier = await service.GetAsync(id);
            if (supplier == null)
            {
                return NotFound();
            }

            service.Delete(supplier);
            await unitOfWork.CommitAsync();
            
            return supplier;
        }

        private bool SuppliersExists(int id)
        {
            // TODO: VC: DELETE
            // return context.Suppliers.Any(e => e.SupplierId == id);

            return service.Exists(id);
        }
    }
}
