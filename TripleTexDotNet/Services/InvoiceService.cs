using System;
using TripleTexDotNet.Interfaces;

namespace TripleTexDotNet.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IJsonService _service;

        public InvoiceService(IJsonService service)
        {
            _service = service;
        }

        public void ImportInvoicesTripletexCsv()
        {
            throw new NotImplementedException();
        }

        public void GetHistoryAmountCurrencyOutstanding()
        {
            throw new NotImplementedException();
        }

        public void CreatePaymentVoucher()
        {
            throw new NotImplementedException();
        }

        public void IsCredited()
        {
            throw new NotImplementedException();
        }
    }
}
