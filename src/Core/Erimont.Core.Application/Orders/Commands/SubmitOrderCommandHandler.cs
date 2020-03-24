﻿using Optivem.Atomiv.Core.Application;
using Erimont.Core.Domain.Orders;
using System.Threading.Tasks;

namespace Erimont.Core.Application.Orders.Commands
{
    public class SubmitOrderCommandHandler : IRequestHandler<SubmitOrderCommand, SubmitOrderCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepository _orderRepository;

        public SubmitOrderCommandHandler(IMapper mapper, IOrderRepository orderRepository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
        }

        public async Task<SubmitOrderCommandResponse> HandleAsync(SubmitOrderCommand request)
        {
            var orderId = new OrderIdentity(request.Id);

            var order = await _orderRepository.FindAsync(orderId);

            order.Submit();

            await _orderRepository.UpdateAsync(order);
            return _mapper.Map<Order, SubmitOrderCommandResponse>(order);
        }
    }
}