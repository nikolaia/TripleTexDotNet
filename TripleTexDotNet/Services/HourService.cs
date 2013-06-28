using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripleTexDotNet.Services
{
    public class HourService
    {
        private readonly SyncService _syncService;

        public HourService(SyncService syncService)
        {
            _syncService = syncService;
        }

        public void HourSave()
        {
            throw new NotImplementedException();
        }

        public void HourGetTimesheet()
        {
            throw new NotImplementedException();
        }
        public void HourRemoveFromTimesheet()
        {
            throw new NotImplementedException();
        }
    }
}
