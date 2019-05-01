using Microsoft.AspNetCore.Mvc;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Application.Services;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Framework.Web.AspNetCore.Rest;

namespace Optivem.Northwind.Web.Rest.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : AspNetCoreCrudController<INorthwindUnitOfWork, IProductService, ProductRequest, ProductResponse, int>
    {
        public ProductsController(INorthwindUnitOfWork unitOfWork, IProductService service)
            : base(unitOfWork, service, e => e.Id, e => e.Id)
        {
        }
    }
}