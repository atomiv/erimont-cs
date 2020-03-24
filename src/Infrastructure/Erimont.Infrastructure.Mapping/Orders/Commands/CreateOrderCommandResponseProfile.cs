using AutoMapper;
using Erimont.Core.Application.Orders.Commands;
using Erimont.Core.Domain.Orders;

namespace Erimont.Infrastructure.Mapping.Orders
{
    public class CreateOrderCommandResponseProfile : Profile
    {
        public CreateOrderCommandResponseProfile()
        {
            CreateMap<Order, CreateOrderCommandResponse>();
                // .ForMember(dest => dest.OrderItems, opt => opt.MapFrom(e => e.OrderItems)); // TODO: VC: DELETE

            CreateMap<OrderItem, CreateOrderItemResponse>();
        }
    }
}
