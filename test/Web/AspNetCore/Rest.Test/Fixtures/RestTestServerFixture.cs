using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Optivem.Northwind.Core.Application.Dto;
using Optivem.Northwind.Core.Domain.Entity;
using Optivem.Northwind.Infrastructure.Domain.Repository.EntityFrameworkCore;
using Optivem.Northwind.Web.Rest;
using Optivem.Platform.Core.Common.Serialization;
using Optivem.Platform.Infrastructure.Common.RestClient.Default;
using Optivem.Platform.Infrastructure.Common.Serialization.Default;
using Optivem.Platform.Test.Xunit.Web.AspNetCore;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using System.Text;

namespace Optivem.Northwind.Web.AspNetCore.Rest.Test.Fixtures
{
    public class RestTestServerFixture : TestServerFixture
    {
        private const string NorthwindContextConnectionStringKey = "Northwind";

        // TODO: VC: Perhaps we could have abstract class for creating webHostBuilder

        // TODO: VC: This is duplication - CreateWebHostBuilder
        public RestTestServerFixture() : base(CreateWebHostBuilder())
        {
            var serializationService = new SerializationService();

            SuppliersControllerClient = new SuppliersControllerClient(HttpClient, serializationService);
        }

        public SuppliersControllerClient SuppliersControllerClient { get; }

        private static IWebHostBuilder CreateWebHostBuilder()
        {
            // TODO: VC: Distinguish between startup which uses appsettings json vs one which does not

            var configurationBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.Test.json");

            var configuration = configurationBuilder
                .Build();


            SeedDatabase(configuration);

            return new WebHostBuilder()
                .UseStartup<Startup>()
                .UseConfiguration(configuration);
        }

        private static void SeedDatabase(IConfigurationRoot configuration)
        {
            var connection = configuration.GetConnectionString(NorthwindContextConnectionStringKey);

            var builder = new DbContextOptionsBuilder<NorthwindContext>()
                .UseSqlServer(connection);

            using (var context = new NorthwindContext(builder.Options))
            {
                context.Database.Migrate();

                var sampleSupplier = new Supplier
                {
                    Id = 0,
                    Address = "dds",
                    BusinessPhone = "fffs",
                    City = "sfsfsf",
                    Company = "sdfsfs",
                    HomePhone = "sffsfs",
                    FaxNumber = "sfsfssf",
                    CountryRegion = "sffsgklf",
                    EmailAddress = "sffss",
                    FirstName = "sfsf",
                    JobTitle = "sffssf",
                    LastName = "wrrw",
                    MobilePhone = "sffgssgs",
                    Notes = "jkjhkjhfs",
                    PurchaseOrder = null,
                    StateProvince = "afffsf",
                    WebPage = "ooeqeio",
                    ZipPostalCode = "adad",
                };

                context.Supplier.Add(sampleSupplier);

                context.SaveChanges();
            }
        }
    }

    public class SuppliersControllerClient
        : RestControllerClient<long, SupplierRequest, SupplierResponse>
    {
        public SuppliersControllerClient(HttpClient client, ISerializationService serializationService) 
            : base(client, "api/suppliers", serializationService)
        {
        }
    }
}
