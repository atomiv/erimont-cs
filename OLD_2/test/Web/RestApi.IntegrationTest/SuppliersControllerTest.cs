using Optivem.Northwind.Core.Application.Suppliers.Requests;
using Optivem.Northwind.Infrastructure.EntityFrameworkCore.Suppliers.Records;
using Optivem.Northwind.Web.RestApi.IntegrationTest.Fixtures;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Optivem.Northwind.Web.RestApi.IntegrationTest
{
    // TODO: VC: When testing, making equivalent tests for application layer and web layer when testing correctness
    // and on web layer just see that it returns web specific things (e.g. status codes)

    public class SuppliersControllerTest : ControllerTest
    {
        private List<SupplierRecord> _supplierRecords;

        public SuppliersControllerTest(ControllerFixture fixture) : base(fixture)
        {
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
        public async Task ListSuppliers_OK()
        {
            var listRequest = new ListSuppliersRequest { };

            var actual = await Fixture.Api.Suppliers.ListSuppliersAsync(listRequest);

            Assert.Equal(HttpStatusCode.OK, actual.StatusCode);

            var actualContent = actual.Data;

            Assert.Equal(2, actualContent.Records.Count);

            var expectedFirst = _supplierRecords[0];
            var actualFirst = actualContent.Records[0];

            Assert.True(actualFirst.Id > 0);
            Assert.Equal(expectedFirst.FirstName, actualFirst.FirstName);
            Assert.Equal(expectedFirst.LastName, actualFirst.LastName);

            var expectedSecond = _supplierRecords[1];
            var actualSecond = actualContent.Records[1];

            Assert.True(actualSecond.Id > 0);
            Assert.Equal(expectedSecond.FirstName, actualSecond.FirstName);
            Assert.Equal(expectedSecond.LastName, actualSecond.LastName);
        }

        [Fact]
        public async Task FindSupplier_Valid_OK()
        {
            var supplierRecord = _supplierRecords[0];
            var id = supplierRecord.Id;

            var findRequest = new FindSupplierRequest { Id = id };

            var findResponse = await Fixture.Api.Suppliers.FindSupplierAsync(findRequest);

            Assert.Equal(HttpStatusCode.OK, findResponse.StatusCode);

            var findResponseContent = findResponse.Data;

            Assert.Equal(supplierRecord.Id, findResponseContent.Id);
            Assert.Equal(supplierRecord.FirstName, findResponseContent.FirstName);
            Assert.Equal(supplierRecord.LastName, findResponseContent.LastName);
        }

        [Fact]
        public async Task FindSupplier_NotExist_NotFound()
        {
            var id = 999;

            var findRequest = new FindSupplierRequest { Id = id };

            var findResponse = await Fixture.Api.Suppliers.FindSupplierAsync(findRequest);

            Assert.Equal(HttpStatusCode.NotFound, findResponse.StatusCode);
        }

        [Fact]
        public async Task CreateSupplier_Valid_Created()
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

            var createResponse = await Fixture.Api.Suppliers.CreateSupplierAsync(createRequest);

            Assert.Equal(HttpStatusCode.Created, createResponse.StatusCode);

            var createResponseContent = createResponse.Data;

            Assert.True(createResponseContent.Id > 0);

            Assert.Equal(createRequest.FirstName, createResponseContent.FirstName);
            Assert.Equal(createRequest.LastName, createResponseContent.LastName);

            var findRequest = new FindSupplierRequest { Id = createResponseContent.Id };

            var findResponse = await Fixture.Api.Suppliers.FindSupplierAsync(findRequest);

            Assert.Equal(HttpStatusCode.OK, findResponse.StatusCode);

            var findResponseContent = findResponse.Data;

            Assert.Equal(createResponseContent.Id, findResponseContent.Id);
            Assert.Equal(createRequest.FirstName, findResponseContent.FirstName);
            Assert.Equal(createRequest.LastName, findResponseContent.LastName);
        }

        [Fact]
        public async Task CreateSupplier_Invalid_UnprocessableEntity()
        {
            // TODO: Request invalid - null, exceeded length, special characters, words, date (date in the past), negative integers for quantities

            var createRequest = new CreateSupplierRequest
            {
                FirstName = null,
                LastName = "Last name 1",
            };

            var createResponse = await Fixture.Api.Suppliers.CreateSupplierAsync(createRequest);

            Assert.Equal(HttpStatusCode.UnprocessableEntity, createResponse.StatusCode);

            var createResponseContent = createResponse.Data;

            var problemDetails = createResponse.ProblemDetails;

            Assert.Equal((int)HttpStatusCode.UnprocessableEntity, problemDetails.Status);
        }

        [Fact]
        public async Task UpdateSupplier_Valid_OK()
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

            var updateResponse = await Fixture.Api.Suppliers.UpdateSupplierAsync(updateRequest);

            Assert.Equal(HttpStatusCode.OK, updateResponse.StatusCode);

            var updateResponseContent = updateResponse.Data;

            Assert.Equal(updateRequest.Id, updateResponseContent.Id);
            Assert.Equal(updateRequest.FirstName, updateResponseContent.FirstName);
            Assert.Equal(updateRequest.LastName, updateResponseContent.LastName);
        }

        [Fact]
        public async Task UpdateSupplier_NotExist_NotFound()
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

            var updateResponse = await Fixture.Api.Suppliers.UpdateSupplierAsync(updateRequest);

            Assert.Equal(HttpStatusCode.NotFound, updateResponse.StatusCode);
        }

        [Fact]
        public async Task UpdateSupplier_Invalid_UnprocessableEntity()
        {
            // TODO: Request invalid - null, exceeded length, special characters, words, date (date in the past), negative integers for quantities

            var supplierRecord = _supplierRecords[0];

            var updateRequest = new UpdateSupplierRequest
            {
                Id = supplierRecord.Id,
                FirstName = "New first name",
                LastName = null,
            };

            var updateResponse = await Fixture.Api.Suppliers.UpdateSupplierAsync(updateRequest);
            Assert.Equal(HttpStatusCode.UnprocessableEntity, updateResponse.StatusCode);

            var problemDetails = updateResponse.ProblemDetails;
            Assert.Equal((int)HttpStatusCode.UnprocessableEntity, problemDetails.Status);
        }

        [Fact]
        public async Task DeleteSupplier_Valid_OK()
        {
            var supplierRecord = _supplierRecords[0];
            var id = supplierRecord.Id;

            var deleteRequest = new DeleteSupplierRequest { Id = id };

            var deleteResponse = await Fixture.Api.Suppliers.DeleteSupplierAsync(deleteRequest);

            Assert.Equal(HttpStatusCode.NoContent, deleteResponse.StatusCode);
        }

        [Fact]
        public async Task DeleteSupplier_NotExist_NotFound()
        {
            var id = 999;

            var deleteRequest = new DeleteSupplierRequest { Id = id };

            var deleteResponse = await Fixture.Api.Suppliers.DeleteSupplierAsync(deleteRequest);

            Assert.Equal(HttpStatusCode.NotFound, deleteResponse.StatusCode);
        }
    }
}