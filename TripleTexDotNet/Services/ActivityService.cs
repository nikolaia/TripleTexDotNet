using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripleTexDotNet.Services
{
    public class ActivityService
    {
        private readonly SyncService _syncService;

        public ActivityService(SyncService syncService)
        {
            _syncService = syncService;
        }

        public void ActivityGetForTimesheet()
        {
            throw new NotImplementedException();
        }
    }
}
