using AutoMapper;
using Erimont.Core.Application.Orders.Commands;
using Erimont.Core.Domain.Orders;

namespace Erimont.Infrastructure.Mapping.Orders
{
    public class EditOrderCommandResponseProfile : Profile
    {
        public EditOrderCommandResponseProfile()
        {
            CreateMap<Order, EditOrderCommandResponse>();

            CreateMap<OrderItem, UpdateOrderItemCommandResponse>();
        }
    }
}
