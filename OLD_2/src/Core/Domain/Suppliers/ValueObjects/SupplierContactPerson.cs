namespace Optivem.Northwind.Core.Domain.Suppliers.ValueObjects
{
    public class SupplierContactPerson
    {
        public SupplierContactPerson(string firstName, 
            string lastName,
            string jobTitle)
        {
            FirstName = firstName;
            LastName = lastName;
            JobTitle = jobTitle;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string JobTitle { get; set; }
    }
}
