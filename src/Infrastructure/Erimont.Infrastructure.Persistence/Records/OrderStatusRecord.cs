﻿using Optivem.Atomiv.Infrastructure.EntityFrameworkCore;
using Erimont.Core.Common.Orders;
using System.Collections.Generic;

namespace Erimont.Infrastructure.Persistence.Records
{
    public class OrderStatusRecord : Record<OrderStatus>
    {
        public OrderStatusRecord()
        {
            OrderRecords = new HashSet<OrderRecord>();
        }

        public string Code { get; set; }

        public virtual ICollection<OrderRecord> OrderRecords { get; set; }
    }
}