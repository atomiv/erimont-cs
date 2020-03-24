using Optivem.Atomiv.Infrastructure.EntityFrameworkCore;
using Erimont.Core.Common.Orders;
using System.Collections.Generic;

namespace Erimont.Infrastructure.Persistence.Records
{
    public class OrderItemStatusRecord : Record<OrderItemStatus>
    {
        public OrderItemStatusRecord()
        {
            OrderItems = new HashSet<OrderItemRecord>();
        }

        public string Code { get; set; }

        public virtual ICollection<OrderItemRecord> OrderItems { get; set; }
    }
}