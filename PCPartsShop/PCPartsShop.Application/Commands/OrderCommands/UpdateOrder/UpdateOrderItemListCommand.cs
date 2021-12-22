﻿using MediatR;
using PCPartsShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCPartsShop.Application.Commands.OrderCommands.UpdateOrder
{
    public class UpdateOrderItemListCommand : IRequest<Order>
    {
        public int OrderId { get; set; }
        public Guid ComponentId { get; set; }
        public string ComponentMake { get; set; }
        public string ComponentModel { get; set; }
        public string ComponentImage { get; set; }
        public string ComponentType { get; set; }
        public double ComponentPrice { get; set; }
    }
}
