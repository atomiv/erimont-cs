using Microsoft.AspNetCore.Mvc;
using Optivem.Northwind.Core.Application.UseCases;
using Optivem.Northwind.Core.Application.Services;
using Optivem.Northwind.Core.Domain.Repositories;
using Optivem.Framework.Web.AspNetCore.Rest;

namespace Optivem.Northwind.Web.Rest.Controllers
{
    [Route("api/order-details")]
    [ApiController]
    public class OrderDetailsController : AspNetCoreCrudController<INorthwindUnitOfWork, IOrderDetailService, OrderDetailRequest, OrderDetailResponse, int>
    {
        public OrderDetailsController(INorthwindUnitOfWork unitOfWork, IOrderDetailService service)
            : base(unitOfWork, service, e => e.Id, e => e.Id)
        {
        }
    }
}