﻿using Optivem.Northwind.Core.Application.UseCases;
using Optivem.Framework.Core.Application.Services;

namespace Optivem.Northwind.Core.Application.Services
{
    public interface IEmployeePrivilegeService : ICrudService<EmployeePrivilegeRequest, EmployeePrivilegeResponse, int>
    {
    }
}