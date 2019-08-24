using Optivem.Northwind.Core.Domain.Entities;
using Optivem.Northwind.Core.Domain.Repositories;
using Optivem.Framework.Infrastructure.Domain.Repositories.EntityFrameworkCore;

namespace Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore
{
    public class PrivilegeRepository : EntityFrameworkRepository<NorthwindContext, Privilege, int>, IPrivilegeRepository
    {
        public PrivilegeRepository(NorthwindContext context)
            : base(context)
        {
        }
    }
}