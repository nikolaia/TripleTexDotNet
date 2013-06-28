namespace TripleTexDotNet.Interfaces
{
    public interface IAccountingReportService
    {
        void GetCustomersOpenRecordsBalanceOut();
        void GetSuppliersOpenRecordsBalanceOut();
    }
}