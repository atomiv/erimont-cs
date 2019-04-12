using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Web.AspNetCore.Rest.Test.Fixtures;
using Optivem.Platform.Test.Xunit.Web.AspNetCore;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Optivem.Northwind.Web.AspNetCore.Rest.Test
{
    public class SuppliersControllerTest : TestServerFixtureTest<RestTestServerFixture>
    {
        public SuppliersControllerTest(RestTestServerFixture testServerFixture) : base(testServerFixture)
        {
        }

        [Fact(Skip = "Should send valid data since address is missing")]
        public async Task TestPostAsyncValid()
        {
            var request = new SupplierRequest
            {
                FirstName = "My first name",
            };

            var response = await TestServerFixture.SuppliersControllerClient.PostAsync(request);

            Assert.Equal(request.FirstName, response.FirstName);
            Assert.True(response.Id > 0);
        }
    }
}
