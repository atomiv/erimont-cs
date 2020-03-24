using Optivem.Atomiv.Infrastructure.SequentialGuid;
using Erimont.Core.Domain.Customers;
using System;

namespace Erimont.Infrastructure.Persistence.IdentityGenerators
{
    public class CustomerIdentityGenerator : IdentityGenerator<CustomerIdentity>
    {
        protected override CustomerIdentity Create(Guid guid)
        {
            return new CustomerIdentity(guid);
        }
    }
}
