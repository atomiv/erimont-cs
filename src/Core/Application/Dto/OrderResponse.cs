using System;

namespace Optivem.Northwind.Core.Application.Dto
{
    public class OrderResponse
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int ShipperId { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipStateProvince { get; set; }
        public string ShipZipPostalCode { get; set; }
        public string ShipCountryRegion { get; set; }
        public decimal ShippingFee { get; set; }
        public decimal Taxes { get; set; }
        public string PaymentType { get; set; }
        public DateTime PaidDate { get; set; }
        public string Notes { get; set; }
        public double TaxRate { get; set; }
        public byte TaxStatusId { get; set; }
        public byte StatusId { get; set; }
    }
}