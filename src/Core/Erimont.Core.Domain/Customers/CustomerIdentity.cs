using Optivem.Atomiv.Core.Domain;
using System;

namespace Erimont.Core.Domain.Customers
{
    public class CustomerIdentity : Identity<Guid>
    {
        public CustomerIdentity(Guid value) : base(value)
        {
        }
    }
}