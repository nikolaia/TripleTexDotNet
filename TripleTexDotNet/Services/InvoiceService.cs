using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripleTexDotNet.Services
{
    public class InvoiceService
    {
        private readonly SyncService _syncService;

        public InvoiceService(SyncService syncService)
        {
            _syncService = syncService;
        }

        public void importInvoicesTripletexCSV()
        {
            throw new NotImplementedException();
        }

        public void getHistoryAmountCurrencyOutstanding()
        {
            throw new NotImplementedException();
        }

        public void createPaymentVoucher()
        {
            throw new NotImplementedException();
        }

        public void isCredited()
        {
            throw new NotImplementedException();
        }
    }
}
