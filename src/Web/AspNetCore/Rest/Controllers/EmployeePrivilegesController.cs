using Microsoft.AspNetCore.Mvc;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Application.Service;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Platform.Web.AspNetCore.Rest;

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