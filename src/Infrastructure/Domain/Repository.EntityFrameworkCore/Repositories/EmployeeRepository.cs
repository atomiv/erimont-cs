using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Framework.Infrastructure.Domain.Repositories.EntityFrameworkCore;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore
{
    public class EmployeeRepository : EntityFrameworkRepository<NorthwindContext, Employee, int>, IEmployeeRepository
    {
        public EmployeeRepository(NorthwindContext context)
            : base(context)
        {
        }
    }
}