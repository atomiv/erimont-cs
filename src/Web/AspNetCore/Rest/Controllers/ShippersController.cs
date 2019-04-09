using Microsoft.AspNetCore.Mvc;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Application.Service;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Platform.Web.AspNetCore.Rest;

namespace Optivem.Northwind.Web.Rest.Controllers
{
    [Route("api/shippers")]
    [ApiController]
    public class ShippersController : AspNetCoreCrudController<INorthwindUnitOfWork, IShipperService, ShipperRequest, ShipperResponse, int>
    {
        public ShippersController(INorthwindUnitOfWork unitOfWork, IShipperService service)
            : base(unitOfWork, service, e => e.Id, e => e.Id)
        {
        }
    }
}