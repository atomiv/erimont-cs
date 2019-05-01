using Optivem.Northwind.Core.Application.Dto;
using Optivem.Framework.Core.Application.Services;

namespace Optivem.Northwind.Core.Application.Services
{
    public interface IOrderStatusService : ICrudService<OrderStatusRequest, OrderStatusResponse, int>
    {
    }
}