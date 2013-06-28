using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripleTexDotNet.Services
{
    public class ProjectService
    {
        private readonly SyncService _syncService;

        public ProjectService(SyncService syncService)
        {
            _syncService = syncService;
        }

        public void ProjectGetForTimesheet()
        {
            throw new NotImplementedException();
        }
    }
}
