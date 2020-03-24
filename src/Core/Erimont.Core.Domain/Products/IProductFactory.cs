using Optivem.Atomiv.Core.Domain;

namespace Erimont.Core.Domain.Products
{
    public interface IProductFactory : IFactory
    {
        Product CreateNewProduct(string productCode, string productName, decimal listPrice);
    }
}
