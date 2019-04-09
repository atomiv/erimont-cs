using System.Collections.Generic;

namespace Optivem.Northwind.Core.Domain.Entity
{
    public partial class Privilege
    {
        public Privilege()
        {
            EmployeePrivilege = new HashSet<EmployeePrivilege>();
        }

        public int Id { get; set; }
        public string PrivilegeName { get; set; }

        public virtual ICollection<EmployeePrivilege> EmployeePrivilege { get; set; }
    }
}