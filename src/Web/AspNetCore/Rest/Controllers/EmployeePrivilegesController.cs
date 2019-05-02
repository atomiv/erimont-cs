using Microsoft.AspNetCore.Mvc;
using Optivem.Northwind.Core.Application.UseCases;
using Optivem.Northwind.Core.Application.Services;
using Optivem.Northwind.Core.Domain.Repositories;
using Optivem.Framework.Web.AspNetCore.Rest;

namespace Optivem.Northwind.Web.Rest.Controllers
{
    [Route("api/employee-privileges")]
    [ApiController]
    public class EmployeePrivilegesController : AspNetCoreCrudController<INorthwindUnitOfWork, IEmployeePrivilegeService, EmployeePrivilegeRequest, EmployeePrivilegeResponse, int>
    {
        public EmployeePrivilegesController(INorthwindUnitOfWork unitOfWork, IEmployeePrivilegeService service)
            : base(unitOfWork, service, e => e.Id, e => e.Id)
        {
        }
    }
}