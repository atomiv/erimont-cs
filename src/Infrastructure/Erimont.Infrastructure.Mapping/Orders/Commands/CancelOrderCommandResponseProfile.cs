using AutoMapper;
using Erimont.Core.Application.Orders.Commands;
using Erimont.Core.Domain.Orders;

namespace Erimont.Infrastructure.Mapping.Orders
{
    public class CancelOrderCommandResponseProfile : Profile
    {
        public CancelOrderCommandResponseProfile()
        {
            CreateMap<Order, CancelOrderCommandResponse>();
        }
    }
}
