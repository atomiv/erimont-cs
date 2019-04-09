using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Core.Domain.Repository;
using Optivem.Platform.Infrastructure.Common.Repository.EntityFrameworkCore;

namespace Optivem.Northwind.Infrastructure.Domain.Repository.EntityFrameworkCore
{
    public class PrivilegeRepository : EntityFrameworkRepository<NorthwindContext, Privilege, int>, IPrivilegeRepository
    {
        public PrivilegeRepository(NorthwindContext context)
            : base(context)
        {
        }
    }
}