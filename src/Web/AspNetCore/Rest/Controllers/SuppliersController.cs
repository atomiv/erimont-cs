using Microsoft.AspNetCore.Mvc;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Application.Services;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Framework.Web.AspNetCore.Rest;

namespace Optivem.Northwind.Web.Rest.Controllers
{
    [Route("api/suppliers")]
    [ApiController]
    public class SuppliersController : AspNetCoreCrudController<INorthwindUnitOfWork, ISupplierService, SupplierRequest, SupplierResponse, int>
    {
        public SuppliersController(INorthwindUnitOfWork unitOfWork, ISupplierService service)
            : base(unitOfWork, service, e => e.Id, e => e.Id)
        {
        }
    }
}