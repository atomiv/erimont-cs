using Microsoft.AspNetCore.Mvc;
using Optivem.Northwind.Core.Application.Dtos;
using Optivem.Northwind.Core.Application.Services;
using Optivem.Northwind.Core.Domain.Repositories;
using Optivem.Framework.Web.AspNetCore.Rest;

namespace Optivem.Northwind.Web.Rest.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : AspNetCoreCrudController<INorthwindUnitOfWork, IOrderService, OrderRequest, OrderResponse, int>
    {
        public OrdersController(INorthwindUnitOfWork unitOfWork, IOrderService service)
            : base(unitOfWork, service, e => e.Id, e => e.Id)
        {
        }
    }
}