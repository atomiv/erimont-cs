﻿using FluentAssertions;
using Erimont.Core.Application.Orders.Commands;
using Erimont.Core.Application.Orders.Queries;
using Erimont.Core.Common.Orders;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Erimont.Web.RestApi.IntegrationTest.Orders.Commands
{
    public class CancelOrderCommandTest : BaseTest
    {
        public CancelOrderCommandTest(Fixture fixture) : base(fixture)
        {
        }

        [Fact]
        public async Task CancelOrder_Valid()
        {
            // Arrange

            var createResponses = await CreateSampleOrdersAsync();
            var someCreateResponse = createResponses[1];

            // Act

            var id = someCreateResponse.Data.Id;
            var cancelRequest = new CancelOrderCommand { Id = id };
            var cancelHttpResponse = await Fixture.Api.Orders.CancelOrderAsync(cancelRequest);

            // Assert

            cancelHttpResponse.StatusCode.Should().Be(HttpStatusCode.OK);

            var archiveResponse = cancelHttpResponse.Data;

            var expectedArchiveResponse = new CancelOrderCommandResponse
            {
                Id = id,
                Status = OrderStatus.Cancelled,
            };

            archiveResponse.Should().BeEquivalentTo(expectedArchiveResponse);

            var findRequest = new ViewOrderQuery { Id = id };
            var findHttpResponse = await Fixture.Api.Orders.ViewOrderAsync(findRequest);

            findHttpResponse.StatusCode.Should().Be(HttpStatusCode.OK);

            var findResponse = findHttpResponse.Data;

            findResponse.Should().BeEquivalentTo(archiveResponse);
        }
    }
}
