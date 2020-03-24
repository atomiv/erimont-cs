﻿using Optivem.Northwind.Core.Domain.Entities;
using Optivem.Northwind.Core.Domain.Repositories;
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