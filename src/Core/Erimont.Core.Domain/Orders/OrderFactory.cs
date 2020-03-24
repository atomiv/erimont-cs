﻿using Optivem.Atomiv.Core.Domain;
using Erimont.Core.Common.Orders;
using Erimont.Core.Domain.Customers;
using Erimont.Core.Domain.Products;
using System;
using System.Collections.Generic;

namespace Erimont.Core.Domain.Orders
{
    public class OrderFactory : IOrderFactory
    {
        private readonly IIdentityGenerator<OrderIdentity> _orderIdentityGenerator;
        private readonly IIdentityGenerator<OrderItemIdentity> _orderItemIdentityGenerator;
        private readonly ITimeService _timeService;

        public OrderFactory(IIdentityGenerator<OrderIdentity> orderIdentityGenerator, 
            IIdentityGenerator<OrderItemIdentity> orderItemIdentityGenerator,
            ITimeService timeService)
        {
            _orderIdentityGenerator = orderIdentityGenerator;
            _orderItemIdentityGenerator = orderItemIdentityGenerator;
            _timeService = timeService;
        }

        public Order CreateNewOrder(CustomerIdentity customerId, IEnumerable<OrderItem> orderItems)
        {
            var id = _orderIdentityGenerator.Next();
            var orderDate = _timeService.Now;
            return new Order(id, customerId, orderDate, OrderStatus.New, orderItems);
        }

        public OrderItem CreateNewOrderItem(ProductIdentity productId, decimal unitPrice, int quantity)
        {
            if (quantity < 0)
            {
                throw new ArgumentException();
            }

            var id = _orderItemIdentityGenerator.Next();

            return new OrderItem(id, productId, unitPrice, quantity, OrderItemStatus.Allocated);
        }
    }
}