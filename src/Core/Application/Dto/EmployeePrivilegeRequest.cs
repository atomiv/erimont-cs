namespace Optivem.Northwind.Core.Application.Dto
{
    public class EmployeePrivilegeRequest
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int PrivilegeId { get; set; }
    }
}