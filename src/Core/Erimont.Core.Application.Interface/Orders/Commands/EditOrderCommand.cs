﻿using Optivem.Atomiv.Core.Application;
using System;
using System.Collections.Generic;

namespace Erimont.Core.Application.Orders.Commands
{
    public class EditOrderCommand : IRequest<EditOrderCommandResponse>
    {
        public Guid Id { get; set; }

        public List<UpdateOrderItemCommand> OrderItems { get; set; }
    }

    public class UpdateOrderItemCommand
    {
        public Guid? Id { get; set; }

        public Guid ProductId { get; set; }

        public int Quantity { get; set; }
    }
}