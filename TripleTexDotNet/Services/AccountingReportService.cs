using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripleTexDotNet.Services
{
    public class AccountingReportService
    {
        private readonly SyncService _syncService;

        public AccountingReportService(SyncService syncService)
        {
            _syncService = syncService;
        }

        public void AccountingReportGetCustomersOpenRecordsBalanceOut()
        {
            throw new NotImplementedException();
        }

        public void AccountingReportGetSuppliersOpenRecordsBalanceOut()
        {
            throw new NotImplementedException();
        }
    }
}
