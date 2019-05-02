using Microsoft.AspNetCore.Mvc;
using Optivem.Northwind.Core.Application.UseCases;
using Optivem.Northwind.Core.Application.Services;
using Optivem.Northwind.Core.Domain.Repositories;
using Optivem.Framework.Web.AspNetCore.Rest;
using Optivem.Northwind.Core.Application.UseCases.SupplierUseCases.CreateSupplier;
using System.Threading.Tasks;
using MediatR;

namespace Optivem.Northwind.Web.Rest.Controllers
{
    /*

    [Route("api/suppliers")]
    [ApiController]
    public class SuppliersController : AspNetCoreCrudController<INorthwindUnitOfWork, ISupplierService, SupplierRequest, SupplierResponse, int>
    {
        public SuppliersController(INorthwindUnitOfWork unitOfWork, ISupplierService service)
            : base(unitOfWork, service, e => e.Id, e => e.Id)
        {
        }
    }

    */

    [Route("api/suppliers")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private INorthwindUnitOfWork _unitOfWork;
        private IMediator _mediator;

        public SuppliersController(INorthwindUnitOfWork unitOfWork, IMediator mediator)
            : base()
        {
            _unitOfWork = unitOfWork;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<CreateSupplierResponse>> PostResource(CreateSupplierRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }
    }
}