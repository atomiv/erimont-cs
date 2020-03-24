﻿using Optivem.Atomiv.Core.Domain;

namespace Erimont.Core.Domain.Customers
{
    public class CustomerIdNameReadModel : IdNameReadModel<CustomerIdentity>
    {
        public CustomerIdNameReadModel(CustomerIdentity id, string name) : base(id, name)
        {
        }
    }
}
