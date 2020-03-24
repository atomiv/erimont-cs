﻿using System.Threading.Tasks;
using Optivem.Atomiv.Core.Application;
using Erimont.Core.Domain.Orders;

namespace Erimont.Core.Application.Orders.Commands
{
    public class ArchiveOrderCommandHandler : IRequestHandler<ArchiveOrderCommand, ArchiveOrderCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepository _orderRepository;

        public ArchiveOrderCommandHandler(IMapper mapper, IOrderRepository orderRepository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
        }

        public async Task<ArchiveOrderCommandResponse> HandleAsync(ArchiveOrderCommand request)
        {
            var orderId = new OrderIdentity(request.Id);

            var order = await _orderRepository.FindAsync(orderId);

            order.Archive();

            await _orderRepository.UpdateAsync(order);
            return _mapper.Map<Order, ArchiveOrderCommandResponse>(order);
        }
    }
}