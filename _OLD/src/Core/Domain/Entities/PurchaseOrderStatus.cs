using System.Collections.Generic;

namespace Optivem.Northwind.Core.Domain.Entities
{
    public partial class PurchaseOrderStatus
    {
        public PurchaseOrderStatus()
        {
            PurchaseOrder = new HashSet<PurchaseOrder>();
        }

        public byte Id { get; set; }
        public string Code { get; set; }

        public virtual ICollection<PurchaseOrder> PurchaseOrder { get; set; }
    }
}