﻿using FluentAssertions;
using Erimont.Core.Application.Customers.Commands;
using Erimont.Core.Application.Customers.Queries;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Erimont.Web.RestApi.IntegrationTest.Customers.Commands
{
    public class DeleteCustomerCommandTest : BaseTest
    {
        public DeleteCustomerCommandTest(Fixture fixture) : base(fixture)
        {
        }

        [Fact]
        public async Task DeleteCustomer_ValidRequest_ReturnsResponse()
        {
            // Arrange

            var createRequests = new List<CreateCustomerCommand>
            {
                new CreateCustomerCommand
                {
                    FirstName = "Mary",
                    LastName = "Smith",
                },

                new CreateCustomerCommand
                {
                    FirstName = "John",
                    LastName = "McDonald",
                },

                new CreateCustomerCommand
                {
                    FirstName = "Rob",
                    LastName = "McDonald",
                },
            };

            var createHttpResponses = await CreateCustomersAsync(createRequests);

            // Act

            var id = createHttpResponses[1].Data.Id;
            var deleteRequest = new DeleteCustomerCommand { Id = id };
            var deleteHttpResponse = await Fixture.Api.Customers.DeleteCustomerAsync(deleteRequest);

            // Assert

            deleteHttpResponse.StatusCode.Should().Be(HttpStatusCode.NoContent);

            var findRequest = new ViewCustomerQuery { Id = id };
            var findHttpResponse = await Fixture.Api.Customers.ViewCustomerAsync(findRequest);
            findHttpResponse.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task DeleteCustomer_NotExistRequest_ThrowsNotFoundRequestException()
        {
            // Arrange

            var createRequests = new List<CreateCustomerCommand>
            {
                new CreateCustomerCommand
                {
                    FirstName = "Mary",
                    LastName = "Smith",
                },

                new CreateCustomerCommand
                {
                    FirstName = "John",
                    LastName = "McDonald",
                },

                new CreateCustomerCommand
                {
                    FirstName = "Rob",
                    LastName = "McDonald",
                },
            };

            await CreateCustomersAsync(createRequests);

            // Act

            var id = Guid.NewGuid();
            var deleteRequest = new DeleteCustomerCommand { Id = id };
            var deleteHttpResponse = await Fixture.Api.Customers.DeleteCustomerAsync(deleteRequest);

            // Assert

            deleteHttpResponse.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }
    }
}
