using Optivem.Northwind.Core.Application.Dto;
using Optivem.Platform.Core.Application.Service;

namespace Optivem.Northwind.Core.Application.Service
{
    public interface IPrivilegeService : ICrudService<PrivilegeRequest, PrivilegeResponse, int>
    {
    }
}