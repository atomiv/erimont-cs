using Microsoft.AspNetCore.Mvc;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Application.Service;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Platform.Web.AspNetCore.Rest;

namespace Optivem.Northwind.Web.Rest.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : AspNetCoreCrudController<INorthwindUnitOfWork, ICustomerService, CustomerRequest, CustomerResponse, int>
    {
        public CustomersController(INorthwindUnitOfWork unitOfWork, ICustomerService service)
            : base(unitOfWork, service, e => e.Id, e => e.Id)
        {
        }
    }
}