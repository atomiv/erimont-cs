using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Optivem.Framework.Core.Common.Mapping;
using Optivem.Framework.Infrastructure.Common.Mapping.AutoMapper;
using Optivem.Northwind.Core.Application.UseCases.SupplierUseCases.CreateSupplier;
using Optivem.Northwind.Core.Domain.Repositories;
using Optivem.Northwind.Infrastructure.Domain.Repositories.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Optivem.Northwind.Core.Application.UseCases.Test
{
    public class CreateSupplierUnitTest
    {
        [Fact]
        public async Task TestValid()
        {
            var services = new ServiceCollection()
                .AddScoped<INorthwindUnitOfWork, NorthwindUnitOfWork>()
                .AddDbContext<NorthwindContext>(options => options.UseInMemoryDatabase("NorthwindContext"))
                .AddMediatR(AppDomain.CurrentDomain.GetAssemblies())
                .AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies())
                .AddScoped<IMappingService, AutoMapperMappingService>();

            var serviceProvider = services.BuildServiceProvider();

            var mediator = serviceProvider.GetRequiredService<IMediator>();
            var mappingService = serviceProvider.GetRequiredService<IMappingService>();

            var request = new CreateSupplierRequest
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

            var response = await mediator.Send(request);

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
    }
}
