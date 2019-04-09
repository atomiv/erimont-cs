using Microsoft.AspNetCore.Mvc;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Application.Service;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Platform.Web.AspNetCore.Rest;

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