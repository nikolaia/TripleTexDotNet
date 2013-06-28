namespace TripleTexDotNet.Interfaces
{
    public interface IInvoiceService
    {
        void ImportInvoicesTripletexCsv();
        void GetHistoryAmountCurrencyOutstanding();
        void CreatePaymentVoucher();
        void IsCredited();
    }
}