﻿using Optivem.Atomiv.Core.Application;
using System;

namespace Erimont.Core.Application.Orders.Queries
{
    public class ViewOrderQuery : IRequest<ViewOrderQueryResponse>
    {
        public Guid Id { get; set; }
    }
}