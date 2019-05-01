using Bogus;
using Optivem.Northwind.Core.Application.Dtos;
using Optivem.Northwind.Web.AspNetCore.Rest.Test.Fixtures;
using Optivem.Framework.Core.Common.RestClient;
using Optivem.Framework.Test.Xunit.Web.AspNetCore;
using System.Threading.Tasks;
using Xunit;

namespace Optivem.Northwind.Web.AspNetCore.Rest.Test
{
    public class SuppliersControllerTest : TestServerFixtureTest<RestTestServerFixture>
    {
        public SuppliersControllerTest(RestTestServerFixture testServerFixture) : base(testServerFixture)
        {
        }

        [Fact]
        public async Task GetAsync_ResourceExists_OK()
        {
            var setupRequest = new SupplierRequest
            {
                Company = "Company 2",
                LastName = "Last name 2",
                FirstName = "First name 2",
                EmailAddress = "Email address 2",
                JobTitle = "Job title 2",
                BusinessPhone = "Phone 2",
                HomePhone = "Home 2",
                MobilePhone = "Mobile 2",
                FaxNumber = "Fax 2",
                Address = "Address 2",
                City = "City 2",
                StateProvince = "State province 2",
                ZipPostalCode = "Zip 2",
                CountryRegion = "Country region 2",
                WebPage = "Web page 2",
                Notes = "Notes 2",
            };

            var setupResponse = await TestServerFixture.SuppliersControllerClient.PostAsync(setupRequest);

            var id = setupResponse.Id;

            var response = await TestServerFixture.SuppliersControllerClient.GetAsync(id);

            Assert.Equal(id, response.Id);
            Assert.Equal(setupRequest.Company, response.Company);
            Assert.Equal(setupRequest.LastName, response.LastName);
            Assert.Equal(setupRequest.FirstName, response.FirstName);
            Assert.Equal(setupRequest.EmailAddress, response.EmailAddress);
            Assert.Equal(setupRequest.JobTitle, response.JobTitle);
            Assert.Equal(setupRequest.BusinessPhone, response.BusinessPhone);
            Assert.Equal(setupRequest.HomePhone, response.HomePhone);
            Assert.Equal(setupRequest.MobilePhone, response.MobilePhone);
            Assert.Equal(setupRequest.FaxNumber, response.FaxNumber);
            Assert.Equal(setupRequest.Address, response.Address);
            Assert.Equal(setupRequest.City, response.City);
            Assert.Equal(setupRequest.StateProvince, response.StateProvince);
            Assert.Equal(setupRequest.ZipPostalCode, response.ZipPostalCode);
            Assert.Equal(setupRequest.CountryRegion, response.CountryRegion);
            Assert.Equal(setupRequest.WebPage, response.WebPage);
            Assert.Equal(setupRequest.Notes, response.Notes);
        }

        [Fact]
        public async Task GetAsync_ResourceNotExists_NotFound()
        {
            var id = 999999999999999;

            await Assert.ThrowsAsync<RestClientException>(() => TestServerFixture.SuppliersControllerClient.GetAsync(id));
        }


        [Fact]
        public async Task PostAsync_RequestValid_Created()
        {
            var request = new SupplierRequest
            {
                Company = "Company 1",
                LastName = "Last name 1",
                FirstName = "First name 1",
                EmailAddress = "Email address 1",
                JobTitle = "Job title 1",
                BusinessPhone = "Phone 1",
                HomePhone = "Home 1",
                MobilePhone = "Mobile 1",
                FaxNumber = "Fax 1",
                Address = "Address 1",
                City = "City 1",
                StateProvince = "State province 1",
                ZipPostalCode = "Zip 1",
                CountryRegion = "Country region 1",
                WebPage = "Web page 1",
                Notes = "Notes 1",
            };

            var response = await TestServerFixture.SuppliersControllerClient.PostAsync(request);

            Assert.True(response.Id > 0);

            Assert.Equal(request.Company, response.Company);
            Assert.Equal(request.LastName, response.LastName);
            Assert.Equal(request.FirstName, response.FirstName);
            Assert.Equal(request.EmailAddress, response.EmailAddress);
            Assert.Equal(request.JobTitle, response.JobTitle);
            Assert.Equal(request.BusinessPhone, response.BusinessPhone);
            Assert.Equal(request.HomePhone, response.HomePhone);
            Assert.Equal(request.MobilePhone, response.MobilePhone);
            Assert.Equal(request.FaxNumber, response.FaxNumber);
            Assert.Equal(request.Address, response.Address);
            Assert.Equal(request.City, response.City);
            Assert.Equal(request.StateProvince, response.StateProvince);
            Assert.Equal(request.ZipPostalCode, response.ZipPostalCode);
            Assert.Equal(request.CountryRegion, response.CountryRegion);
            Assert.Equal(request.WebPage, response.WebPage);
            Assert.Equal(request.Notes, response.Notes);
        }

        [Fact]
        public async Task PutAsync_ResourceExistsRequestValid_OK()
        {
            var setupRequest = new SupplierRequest
            {
                Company = "Company 3",
                LastName = "Last name 3",
                FirstName = "First name 3",
                EmailAddress = "Email address 3",
                JobTitle = "Job title 3",
                BusinessPhone = "Phone 3",
                HomePhone = "Home 3",
                MobilePhone = "Mobile 3",
                FaxNumber = "Fax 3",
                Address = "Address 3",
                City = "City 3",
                StateProvince = "State province 3",
                ZipPostalCode = "Zip 3",
                CountryRegion = "Country region 3",
                WebPage = "Web page 3",
                Notes = "Notes 3",
            };

            var setupResponse = await TestServerFixture.SuppliersControllerClient.PostAsync(setupRequest);

            var id = setupResponse.Id;

            var updateRequest = new SupplierRequest
            {
                Id = id, // TODO: VC: Remove
                Company = "Company 4",
                LastName = "Last name 4",
                FirstName = "First name 4",
                EmailAddress = "Email address 4",
                JobTitle = "Job title 4",
                BusinessPhone = "Phone 4",
                HomePhone = "Home 4",
                MobilePhone = "Mobile 4",
                FaxNumber = "Fax 4",
                Address = "Address 4",
                City = "City 4",
                StateProvince = "State province 4",
                ZipPostalCode = "Zip 4",
                CountryRegion = "Country region 4",
                WebPage = "Web page 4",
                Notes = "Notes 4",
            };


            await TestServerFixture.SuppliersControllerClient.PutAsync(id, updateRequest);
        }

        [Fact]
        public async Task PutAsync_ResourceNotExists_NotFound()
        {
            var id = 9999999999999;

            var updateRequest = new SupplierRequest
            {
            };

            await Assert.ThrowsAsync<RestClientException>(() => TestServerFixture.SuppliersControllerClient.PutAsync(id, updateRequest));
        }

        [Fact]
        public async Task DeleteAsync_ResourceExists_OK()
        {
            var setupRequest = new SupplierRequest
            {
                Company = "Company 1",
                LastName = "Last name 1",
                FirstName = "First name 1",
                EmailAddress = "Email address 1",
                JobTitle = "Job title 1",
                BusinessPhone = "Phone 1",
                HomePhone = "Home 1",
                MobilePhone = "Mobile 1",
                FaxNumber = "Fax 1",
                Address = "Address 1",
                City = "City 1",
                StateProvince = "State province 1",
                ZipPostalCode = "Zip 1",
                CountryRegion = "Country region 1",
                WebPage = "Web page 1",
                Notes = "Notes 1",
            };

            var setupResponse = await TestServerFixture.SuppliersControllerClient.PostAsync(setupRequest);

            var id = setupResponse.Id;

            // TODO: VC: Test response
            await TestServerFixture.SuppliersControllerClient.DeleteAsync(id);
        }

        [Fact]
        public async Task DeleteAsync_ResourceNotExists_NotFound()
        {
            var id = 9999999999999;

            // TODO: VC: Test response
            await Assert.ThrowsAsync<RestClientException>(() => TestServerFixture.SuppliersControllerClient.DeleteAsync(id));
        }




        // TODO: VC: Platform - consider testing for AutoMapperProfile bases in platform... also perhaps AutoMapper specifically for web, i.e. the request, response, etc

        // TODO: VC: IN platform, base class for the controller fixtures and for controller tests - this is useful for testing that the mappings are configured well.... so could test retrieval, and crud submission
        // TODO: VC: After crud works well then move onto process

        // TODO: VC: Special handling for enums, e.g. statuses




        // TODO: VC: Platform: Modifying to return value instead of throwing exception, so that it returns status code -> or perhaps just for testing

        // TODO: VC: Platform: Removing Id from the request because it's in the path

        // TODO: VC: GET: Returning NoContent, or perhaps consider returning content?
    }
}