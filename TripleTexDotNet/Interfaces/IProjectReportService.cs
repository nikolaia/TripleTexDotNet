namespace TripleTexDotNet.Interfaces
{
    public interface IProjectReportService
    {
        void GetSumEmployeeChargeableHours();
        void GetSumHours();
        void GetSumEmployeeNonChargeablePaymentHours();
        void GetEmployeeChargeablePercentage();
        void GetDepartmentChargeablePercentage();
        void GetSumDepartmentChargeableHours();
        void GetDepartmentProjectsFee();
        void GetDepartmentProjectsNetRate();
        void GetDepartmentProjectsNetAmount();
        void GetCompanyChargeablePercentage();
        void GetSumCompanyChargeableHours();
        void GetCompanyProjectsFee();
        void GetCompanyProjectsNetAmount();
        void GetCompanyProjectsNetRate();
        void GetSumHourlyRateProjectsChargeableHours();
        void GetHourlyRateProjectsFee();
        void GetHourlyRateProjectsFeeRate();
    }
}