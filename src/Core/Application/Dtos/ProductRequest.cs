namespace Optivem.Northwind.Core.Application.Dtos
{
    public class ProductRequest
    {
        public int Id { get; set; }
        public string SupplierId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal StandardCost { get; set; }
        public decimal ListPrice { get; set; }
        public short ReorderLevel { get; set; }
        public int TargetLevel { get; set; }
        public string QuantityPerUnit { get; set; }
        public bool Discontinued { get; set; }
        public short MinimumReorderQuantity { get; set; }
        public string Category { get; set; }
    }
}