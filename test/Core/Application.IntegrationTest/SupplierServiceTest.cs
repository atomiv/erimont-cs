using Optivem.Framework.Core.Application;
using Optivem.Northwind.Core.Application.Suppliers.Requests;
using Optivem.Northwind.Core.Application.IntegrationTest.Fixtures;
using Optivem.Northwind.Infrastructure.EntityFrameworkCore.Suppliers.Records;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Optivem.Northwind.Core.Application.IntegrationTest
{
    public class SupplierServiceTest : ServiceTest
    {
        private readonly List<SupplierRecord> _supplierRecords;

        public SupplierServiceTest(ServiceFixture fixture) : base(fixture)
        {
            // TODO: VC: Perhaps should not directly use DB, but rather the add methos

            _supplierRecords = new List<SupplierRecord>
            {
                new SupplierRecord
                {
                    Company = "Company A",
                    LastName = "Last name A",
                    FirstName = "First name A",
                    EmailAddress = "Email address A",
                    JobTitle = "Job title A",
                    BusinessPhone = "Business phone A",
                    HomePhone = "Home phone A",
                    MobilePhone = "Mobile phone A",
                    FaxNumber = "Fax number A",
                    Address = "Address A",
                    City = "City A",
                    StateProvince = "State A",
                    ZipPostalCode = "Zip A",
                    CountryRegion = "Country A",
                    WebPage = "Web A",
                    Notes = "Notes A",
                },

                new SupplierRecord
                {
                    Company = "Company B",
                    LastName = "Last name B",
                    FirstName = "First name B",
                    EmailAddress = "Email Bddress B",
                    JobTitle = "Job title B",
                    BusinessPhone = "Business phone B",
                    HomePhone = "Home phone B",
                    MobilePhone = "Mobile phone B",
                    FaxNumber = "Fax number B",
                    Address = "Address B",
                    City = "City B",
                    StateProvince = "State B",
                    ZipPostalCode = "Zip B",
                    CountryRegion = "Country B",
                    WebPage = "Web B",
                    Notes = "Notes B",
                }
            };

            Fixture.Db.AddRange(_supplierRecords);
        }

        [Fact]
        public async Task CreateSupplier_ValidRequest_ReturnsResponse()
        {
            var createRequest = new CreateSupplierRequest
            {
                Company = "Company 1",
                LastName = "Last name 1",
                FirstName = "First name 1",
                EmailAddress = "Email address 1",
                JobTitle = "Job title 1",
                BusinessPhone = "Business phone 1",
                HomePhone = "Home phone 1",
                MobilePhone = "Mobile phone 1",
                FaxNumber = "Fax number 1",
                Address = "Address 1",
                City = "City 1",
                StateProvince = "State 1",
                ZipPostalCode = "Zip 1",
                CountryRegion = "Country 1",
                WebPage = "Web 1",
                Notes = "Notes 1",
            };

            var createResponse = await Fixture.Suppliers.CreateSupplierAsync(createRequest);

            Assert.True(createResponse.Id > 0);
            Assert.Equal(createRequest.FirstName, createResponse.FirstName);
            Assert.Equal(createRequest.LastName, createResponse.LastName);

            var findRequest = new FindSupplierRequest { Id = createResponse.Id };

            var findResponse = await Fixture.Suppliers.FindSupplierAsync(findRequest);

            Assert.Equal(findRequest.Id, findResponse.Id);
            Assert.Equal(createRequest.FirstName, findResponse.FirstName);
            Assert.Equal(createRequest.LastName, findResponse.LastName);
        }

        [Fact]
        public async Task CreateSupplier_InvalidRequest_ThrowsInvalidRequestException()
        {
            // TODO: Request invalid - null, exceeded length, special characters, words, date (date in the past), negative integers for quantities
            // TODO: VC: That detailed validation should be in unit tests

            var createRequest = new CreateSupplierRequest
            {
                FirstName = null,
                LastName = "Last name 1",
            };


            await Assert.ThrowsAsync<InvalidRequestException>(() => Fixture.Suppliers.CreateSupplierAsync(createRequest));

            // TODO: Verify that the element was not added by comparing count before and after
        }

        [Fact]
        public async Task DeleteSupplier_ValidRequest_ReturnsResponse()
        {
            var supplierRecord = _supplierRecords[0];
            var id = supplierRecord.Id;

            var deleteRequest = new DeleteSupplierRequest { Id = id };
            var deleteResponse = await Fixture.Suppliers.DeleteSupplierAsync(deleteRequest);

            // TODO: VC: Assert that when try find it does not exist
        }

        [Fact]
        public async Task DeleteSupplier_NotExistRequest_ThrowsNotFoundRequestException()
        {
            var id = 999;

            var deleteRequest = new DeleteSupplierRequest { Id = id };
            
            await Assert.ThrowsAsync<NotFoundRequestException>(() => Fixture.Suppliers.DeleteSupplierAsync(deleteRequest));
        }

        [Fact]
        public async Task FindSupplier_ValidRequest_ReturnsSupplier()
        {
            var supplierRecord = _supplierRecords[0];
            var id = supplierRecord.Id;

            var findRequest = new FindSupplierRequest { Id = id };
            var findResponse = await Fixture.Suppliers.FindSupplierAsync(findRequest);

            Assert.Equal(supplierRecord.Id, findResponse.Id);
            Assert.Equal(supplierRecord.FirstName, findResponse.FirstName);
            Assert.Equal(supplierRecord.LastName, findResponse.LastName);
        }

        [Fact]
        public async Task FindSupplier_NotExistRequest_ThrowsNotFoundRequestException()
        {
            var id = 999;

            var findRequest = new FindSupplierRequest { Id = id };

            await Assert.ThrowsAsync<NotFoundRequestException>(() => Fixture.Suppliers.FindSupplierAsync(findRequest));
        }

        [Fact]
        public async Task ListSuppliers_ValidRequest_ReturnsResponse()
        {
            var request = new ListSuppliersRequest();

            var actualResponse = await Fixture.Suppliers.ListSuppliersAsync(request);

            Assert.Equal(_supplierRecords.Count, actualResponse.Count);

            for(int i = 0; i < _supplierRecords.Count; i++)
            {
                var expectedRecord = _supplierRecords[i];
                var actualRecord = actualResponse.Records[i];

                Assert.Equal(expectedRecord.Id, actualRecord.Id);
                Assert.Equal(expectedRecord.FirstName, actualRecord.FirstName);
                Assert.Equal(expectedRecord.LastName, actualRecord.LastName);
            }
        }

        [Fact]
        public async Task UpdateSupplier_ValidRequest_ReturnsResponse()
        {
            // TODO: Request invalid - null, exceeded length, special characters, words, date (date in the past), negative integers for quantities

            var supplierRecord = _supplierRecords[0];

            var updateRequest = new UpdateSupplierRequest
            {
                Id = supplierRecord.Id,
                Company = "Company 1",
                LastName = "Last name 1",
                FirstName = "First name 1",
                EmailAddress = "Email address 1",
                JobTitle = "Job title 1",
                BusinessPhone = "Business phone 1",
                HomePhone = "Home phone 1",
                MobilePhone = "Mobile phone 1",
                FaxNumber = "Fax number 1",
                Address = "Address 1",
                City = "City 1",
                StateProvince = "State 1",
                ZipPostalCode = "Zip 1",
                CountryRegion = "Country 1",
                WebPage = "Web 1",
                Notes = "Notes 1",
            };

            var updateResponse = await Fixture.Suppliers.UpdateSupplierAsync(updateRequest);

            Assert.Equal(updateRequest.Id, updateResponse.Id);
            Assert.Equal(updateRequest.FirstName, updateResponse.FirstName);
            Assert.Equal(updateRequest.LastName, updateResponse.LastName);
        }

        [Fact]
        public async Task UpdateSupplier_NotExistRequest_ThrowsNotFoundRequestException()
        {
            // TODO: Request invalid - null, exceeded length, special characters, words, date (date in the past), negative integers for quantities

            var supplierRecord = _supplierRecords[0];

            var updateRequest = new UpdateSupplierRequest
            {
                Id = 999,
                Company = "Company 1",
                LastName = "Last name 1",
                FirstName = "First name 1",
                EmailAddress = "Email address 1",
                JobTitle = "Job title 1",
                BusinessPhone = "Business phone 1",
                HomePhone = "Home phone 1",
                MobilePhone = "Mobile phone 1",
                FaxNumber = "Fax number 1",
                Address = "Address 1",
                City = "City 1",
                StateProvince = "State 1",
                ZipPostalCode = "Zip 1",
                CountryRegion = "Country 1",
                WebPage = "Web 1",
                Notes = "Notes 1",
            };

            await Assert.ThrowsAsync<NotFoundRequestException>(() => Fixture.Suppliers.UpdateSupplierAsync(updateRequest));
        }

        [Fact]
        public async Task UpdateSupplier_InvalidRequest_ThrowsInvalidRequestException()
        {
            // TODO: Request invalid - null, exceeded length, special characters, words, date (date in the past), negative integers for quantities

            var supplierRecord = _supplierRecords[0];

            var updateRequest = new UpdateSupplierRequest
            {
                Id = supplierRecord.Id,
                FirstName = "New first name",
                LastName = null,
            };

            await Assert.ThrowsAsync<InvalidRequestException>(() => Fixture.Suppliers.UpdateSupplierAsync(updateRequest));
        }
    }
}
