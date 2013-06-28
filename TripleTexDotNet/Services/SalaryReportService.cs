using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripleTexDotNet.Services
{
    public class SalaryReportService
    {
        private readonly SyncService _syncService;

        public SalaryReportService(SyncService syncService)
        {
            _syncService = syncService;
        }

        public void SalaryGetEmployeeVacationBalance()
        {
            throw new NotImplementedException();
        }
    }
}
