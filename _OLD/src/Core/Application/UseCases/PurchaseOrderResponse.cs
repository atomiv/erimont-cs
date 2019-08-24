using System;

namespace Optivem.Northwind.Core.Application.UseCases
{
    public class PurchaseOrderResponse
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime SubmittedDate { get; set; }
        public DateTime CreationDate { get; set; }
        public byte StatusId { get; set; }
        public DateTime ExpectedDate { get; set; }
        public decimal ShippingFee { get; set; }
        public decimal Taxes { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal PaymentAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string Notes { get; set; }
        public int ApprovedBy { get; set; }
        public DateTime ApprovedDate { get; set; }
        public int SubmittedBy { get; set; }
    }
}