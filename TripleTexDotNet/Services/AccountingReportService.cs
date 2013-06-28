using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TripleTexDotNet.Interfaces;

namespace TripleTexDotNet.Services
{
    public class AccountingReportService : IAccountingReportService
    {
        private readonly IJsonService _service;

        public AccountingReportService(IJsonService service)
        {
            _service = service;
        }

        public void GetCustomersOpenRecordsBalanceOut()
        {
            throw new NotImplementedException();
        }

        public void GetSuppliersOpenRecordsBalanceOut()
        {
            throw new NotImplementedException();
        }
    }
}
