﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Optivem.Atomiv.Core.Application;
using Erimont.Core.Application.Products.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Erimont.Web.RestApi.Services
{
    // TODO: VC: Should this be in application layer because it's shared, or in infrastructure?

    public class ProductSynchronizationService : IHostedService
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public ProductSynchronizationService(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            using(var scope = _serviceScopeFactory.CreateScope())
            {
                var messageBus = scope.ServiceProvider.GetRequiredService<IMessageBus>();

                var command = new SyncProductsCommand();

                await messageBus.SendAsync(command);
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
