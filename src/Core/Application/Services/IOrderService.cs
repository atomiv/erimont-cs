using Optivem.Northwind.Core.Application.Dtos;
using Optivem.Framework.Core.Application.Services;

namespace Optivem.Northwind.Core.Application.Services
{
    public interface IOrderService : ICrudService<OrderRequest, OrderResponse, int>
    {
    }
}