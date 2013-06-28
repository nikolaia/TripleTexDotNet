using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TripleTexDotNet.Classes;

namespace TripleTexDotNet.Services
{
    public class OrderService
    {
        private readonly SyncService _syncService;

        public OrderService(SyncService syncService)
        {
            _syncService = syncService;
        }

        public Order ImportOrdersTripletexCsv(Order order)
        {
            return _syncService.GetService().Call<Order>("Project.importOrdersTripletexCSV", Helpers.ObjectToCsvString(order), "UTF-8", false, false, true);
        }
    }
}
