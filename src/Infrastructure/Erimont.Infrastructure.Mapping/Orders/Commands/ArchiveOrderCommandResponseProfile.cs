using AutoMapper;
using Erimont.Core.Application.Orders.Commands;
using Erimont.Core.Domain.Orders;

namespace Erimont.Infrastructure.Mapping.Orders
{
    public class ArchiveOrderCommandResponseProfile : Profile
    {
        public ArchiveOrderCommandResponseProfile()
        {
            CreateMap<Order, ArchiveOrderCommandResponse>();
        }
    }
}
