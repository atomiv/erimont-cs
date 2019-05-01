namespace Optivem.Northwind.Core.Application.Dtos
{
    public class EmployeePrivilegeRequest
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int PrivilegeId { get; set; }
    }
}