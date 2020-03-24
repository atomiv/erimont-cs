using Optivem.Framework.Core.Application;

namespace Optivem.Northwind.Core.Application.Suppliers.Requests
{
    public class DeleteSupplierRequest : IRequest<int>
    {
        public int Id { get; set; }
    }
}
