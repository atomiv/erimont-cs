using Optivem.Northwind.Core.Application.Dto;
using Optivem.Platform.Core.Application.Service;

namespace Optivem.Northwind.Core.Application.Service
{
    public interface IOrderService : ICrudService<OrderRequest, OrderResponse, int>
    {
    }
}