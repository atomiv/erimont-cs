using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Web.AspNetCore.Rest.Test.Fixtures;
using Optivem.Platform.Test.Xunit.Web.AspNetCore;
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
        public async Task TestPostAsyncValid()
        {
            var request = new SupplierRequest
            {
                Address = "dds",
                BusinessPhone = "fffs",
                City = "sfsfsf",
                Company = "sdfsfs",
                HomePhone = "sffsfs",
                FaxNumber = "sfsfssf",
                CountryRegion = "sffsgklf",
                EmailAddress = "sffss",
                FirstName = "My first name",
                JobTitle = "sffssf",
                LastName = "wrrw",
                MobilePhone = "sffgssgs",
                Notes = "jkjhkjhfs",
                StateProvince = "afffsf",
                WebPage = "ooeqeio",
                ZipPostalCode = "adad",
            };

            var response = await TestServerFixture.SuppliersControllerClient.PostAsync(request);

            Assert.Equal(request.FirstName, response.FirstName);
            Assert.True(response.Id > 0);
        }

        [Fact(Skip = "Need check regarding getting id from seed data")]
        public async Task TestGetAsync()
        {
            var response = await TestServerFixture.SuppliersControllerClient.GetAsync(1028);

            Assert.NotNull(response);

            // TODO: VC: assert that posted data has been inserted, or perhaps via checking from seeding...
        }

        // TODO: VC: Platform - consider testing for AutoMapperProfile bases in platform... also perhaps AutoMapper specifically for web, i.e. the request, response, etc
    }
}
