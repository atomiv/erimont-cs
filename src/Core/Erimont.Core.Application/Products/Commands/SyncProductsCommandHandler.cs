using Optivem.Atomiv.Core.Application;
using Erimont.Core.Domain.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Erimont.Core.Application.Products.Commands
{
    public class SyncProductsCommandHandler : IRequestHandler<SyncProductsCommand, SyncProductsCommandResponse>
    {
        private readonly IProductProviderService _productProviderService;
        private readonly IProductRepository _productRepository;

        public SyncProductsCommandHandler(IProductProviderService productProviderService,
            IProductRepository productRepository)
        {
            _productProviderService = productProviderService;
            _productRepository = productRepository;
        }

        public async Task<SyncProductsCommandResponse> HandleAsync(SyncProductsCommand request)
        {
            var products = await _productProviderService.GetProductsAsync();

            await _productRepository.SyncAsync(products);

            return new SyncProductsCommandResponse();
        }
    }
}
