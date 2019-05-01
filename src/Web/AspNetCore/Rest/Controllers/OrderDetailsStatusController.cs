using Microsoft.AspNetCore.Mvc;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Application.Services;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Framework.Web.AspNetCore.Rest;

namespace Optivem.Northwind.Web.Rest.Controllers
{
    [Route("api/order-details-status")]
    [ApiController]
    public class OrderDetailsStatusController : AspNetCoreCrudController<INorthwindUnitOfWork, IOrderDetailStatusService, OrderDetailStatusRequest, OrderDetailStatusResponse, int>
    {
        public OrderDetailsStatusController(INorthwindUnitOfWork unitOfWork, IOrderDetailStatusService service)
            : base(unitOfWork, service, e => e.Id, e => e.Id)
        {
        }
    }
}