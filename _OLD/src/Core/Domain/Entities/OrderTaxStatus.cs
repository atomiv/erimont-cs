using System.Collections.Generic;

namespace Optivem.Northwind.Core.Domain.Entities
{
    public partial class OrderTaxStatus
    {
        public OrderTaxStatus()
        {
            Order = new HashSet<Order>();
        }

        public byte Id { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}