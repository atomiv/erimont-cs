using System;
using System.Collections.Generic;

namespace Optivem.Northwind.Core.Domain.Entity
{
    public partial class InventoryTransactionType
    {
        public InventoryTransactionType()
        {
            InventoryTransaction = new HashSet<InventoryTransaction>();
        }

        public byte Id { get; set; }
        public string Code { get; set; }

        public virtual ICollection<InventoryTransaction> InventoryTransaction { get; set; }
    }
}
