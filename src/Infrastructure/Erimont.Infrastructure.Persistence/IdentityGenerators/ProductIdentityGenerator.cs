using Optivem.Atomiv.Infrastructure.SequentialGuid;
using Erimont.Core.Domain.Products;
using System;

namespace Erimont.Infrastructure.Persistence.IdentityGenerators
{
    public class ProductIdentityGenerator : IdentityGenerator<ProductIdentity>
    {
        protected override ProductIdentity Create(Guid guid)
        {
            return new ProductIdentity(guid);
        }
    }
}
