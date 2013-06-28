using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripleTexDotNet.Services
{
    public class EmployeeService
    {
        private readonly SyncService _syncService;

        public EmployeeService(SyncService syncService)
        {
            _syncService = syncService;
        }

        public void EmployeeGetLoginEmployeeUsers()
        {
            throw new NotImplementedException();
        }

        public void GetCurrentUsers()
        {
            throw new NotImplementedException();
        }
    }
}
