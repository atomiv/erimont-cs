namespace Optivem.Northwind.Core.Domain.Suppliers.ValueObjects
{
    public class SupplierAddress
    {
        public SupplierAddress(string address,
            string city,
            string stateProvince,
            string zipPostalCode,
            string countryRegion)
        {
            Address = address;
            City = city;
            StateProvince = stateProvince;
            ZipPostalCode = zipPostalCode;
            CountryRegion = countryRegion;
        }

        public string Address { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string ZipPostalCode { get; set; }
        public string CountryRegion { get; set; }

    }
}
