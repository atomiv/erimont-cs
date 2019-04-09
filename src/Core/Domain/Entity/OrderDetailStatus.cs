using System.Collections.Generic;

namespace Optivem.Northwind.Core.Domain.Entity
{
    public partial class OrderDetailStatus
    {
        public OrderDetailStatus()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public byte Id { get; set; }
        public string Code { get; set; }

        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}