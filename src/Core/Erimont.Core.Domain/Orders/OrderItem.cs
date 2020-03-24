﻿using Optivem.Atomiv.Core.Domain;
using Erimont.Core.Common.Orders;
using Erimont.Core.Domain.Products;

namespace Erimont.Core.Domain.Orders
{
    public class OrderItem : Entity<OrderItemIdentity>, IReadonlyOrderItem
    {
        public OrderItem(OrderItemIdentity id, ProductIdentity productId, decimal unitPrice, int quantity, OrderItemStatus status)
            : base(id)
        {
            ProductId = productId;
            UnitPrice = unitPrice;
            Quantity = quantity;
            Status = status;
        }

        public OrderItem(IReadonlyOrderItem orderItem)
            : this(orderItem.Id, orderItem.ProductId, orderItem.UnitPrice, orderItem.Quantity, orderItem.Status)
        {

        }

        public ProductIdentity ProductId { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public OrderItemStatus Status { get; }

        // TODO: VC: CHeck if needed

        /*
        public void ChangeProduct(ProductIdentity productId, decimal unitPrice, int quantity)
        {
            ProductId = productId;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }

        public void ChangeQuantity(int quantity)
        {
            Quantity = quantity;
        }
        */
    }
}