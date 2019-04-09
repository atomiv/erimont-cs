using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Platform.Infrastructure.Common.Repository.EntityFrameworkCore;

namespace Optivem.Northwind.Infrastructure.Domain.Repository.EntityFrameworkCore
{
    public class EmployeePrivilegeRepository : EntityFrameworkRepository<NorthwindContext, EmployeePrivilege, int>, IEmployeePrivilegeRepository
    {
        public EmployeePrivilegeRepository(NorthwindContext context)
            : base(context)
        {
        }
    }
}