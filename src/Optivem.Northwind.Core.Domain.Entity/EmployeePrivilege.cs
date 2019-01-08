using System;
using System.Collections.Generic;

namespace Optivem.Northwind.Core.Domain.Entity
{
    public partial class EmployeePrivilege
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int PrivilegeId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Privilege Privilege { get; set; }
    }
}
