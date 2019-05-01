using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Framework.Infrastructure.Domain.Repositories.EntityFrameworkCore;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore
{
    public class EmployeePrivilegeRepository : EntityFrameworkRepository<NorthwindContext, EmployeePrivilege, int>, IEmployeePrivilegeRepository
    {
        public EmployeePrivilegeRepository(NorthwindContext context)
            : base(context)
        {
        }
    }
}