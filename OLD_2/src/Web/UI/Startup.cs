using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Optivem.Framework.Core.Common.Http;
using Optivem.Framework.Core.Common.Reflection;
using Optivem.Framework.Core.Common.Serialization;
using Optivem.Framework.Infrastructure.AspNetCore;
using Optivem.Framework.Infrastructure.NewtonsoftJson;
using Optivem.Framework.Infrastructure.System.Reflection;
using Optivem.Northwind.Core.Application.Customers.Services;
using Optivem.Northwind.Web.RestClient;
using Optivem.Northwind.Web.RestClient.Http;
using Optivem.Northwind.Web.RestClient.Interface;
using Optivem.Northwind.Web.UI.Services;
using Optivem.Northwind.Web.UI.Services.Interfaces;

namespace Optivem.Northwind.Web.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // TODO: VC: These could be auto-loaded via dependency injection for razor perhaps


            // services.AddScoped<ICustomerPageService, FakeCustomerPageService>();

            //  clientFactory

            services.Configure<ApiClientOptions>(Configuration.GetSection("ApiClient"));


            // IClient client, IJsonSerializer serializer, IPropertyMapper propertyFactory

            services.AddScoped<IClient, ApiClient>();
            services.AddScoped<IJsonSerializer, JsonSerializer>();
            services.AddScoped<IPropertyMapper, PropertyMapper>();

            services.AddScoped<IControllerClientFactory, JsonControllerClientFactory>();
            services.AddScoped<ICustomerHttpService, CustomerHttpService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<ICustomerPageService, CustomerPageService>();

            // TODO: VC: Global handling of ErrorException, showing popup to user or redirecting to error page
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // TODO: VC: Error handling

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc();
        }
    }
}
