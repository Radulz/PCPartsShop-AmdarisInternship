﻿using MediatR;
using PCPartsShop.Interfaces;
using PCPartsShop.Models;
using PCPartsShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PCPartsShop.Commands.RAMCommands.GetRAM
{
    public class GetRAMByIdQueryHandler : IRequestHandler<GetRAMByIdQuery, RAM>
    {
        private IComponentRepository<RAM> _RAMs;

        public GetRAMByIdQueryHandler()
        {
            
        }
        private void EstablishConnection()
        {
            string connectionString = @"Server=RADULZ-DESKTOP\SQLEXPRESS;Database=Amdaris_PCPartsShop;Trusted_Connection=True;";
            var dbContext = new PCPartsShopContext(connectionString);
            dbContext.Database.EnsureCreated();
            _RAMs = new RAMRepository(dbContext);
        }
        public Task<RAM> Handle(GetRAMByIdQuery request, CancellationToken cancellationToken)
        {
            EstablishConnection();
            var r = _RAMs.GetItem(request.RAMId);
            return Task.FromResult(r);
        }
    }
}
