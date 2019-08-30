namespace Optivem.Northwind.Core.Domain.Suppliers.ValueObjects
{
    public class SupplierContactDetails
    {
        public SupplierContactDetails(string emailAddress,
            string businessPhone,
            string homePhone,
            string mobilePhone,
            string faxNumber,
            string webPage)
        {
            EmailAddress = emailAddress;
            BusinessPhone = businessPhone;
            HomePhone = homePhone;
            MobilePhone = mobilePhone;
            FaxNumber = faxNumber;
            WebPage = webPage;
        }

        public string EmailAddress { get; set; }

        public string BusinessPhone { get; set; }

        public string HomePhone { get; set; }

        public string MobilePhone { get; set; }

        public string FaxNumber { get; set; }

        public string WebPage { get; set; }
    }
}
