using Microsoft.AspNetCore.Mvc;
using Optivem.Northwind.Core.Application.Dtos;
using Optivem.Northwind.Core.Application.Services;
using Optivem.Northwind.Core.Domain.Repositories;
using Optivem.Framework.Web.AspNetCore.Rest;

namespace Optivem.Northwind.Web.Rest.Controllers
{
    [Route("api/privileges")]
    [ApiController]
    public class PrivilegesController : AspNetCoreCrudController<INorthwindUnitOfWork, IPrivilegeService, PrivilegeRequest, PrivilegeResponse, int>
    {
        public PrivilegesController(INorthwindUnitOfWork unitOfWork, IPrivilegeService service)
            : base(unitOfWork, service, e => e.Id, e => e.Id)
        {
        }
    }
}