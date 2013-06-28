using System;
using TripleTexDotNet.Interfaces;

namespace TripleTexDotNet.Services
{
    public class ProjectReportService : IProjectReportService
    {
        private readonly IJsonService _service;

        public ProjectReportService(IJsonService service)
        {
            _service = service;
        }

        public void GetSumEmployeeChargeableHours()
        {
            throw new NotImplementedException();
        }
        public void GetSumHours()
        {
            throw new NotImplementedException();
        }
        public void GetSumEmployeeNonChargeablePaymentHours()
        {
            throw new NotImplementedException();
        }
        public void GetEmployeeChargeablePercentage()
        {
            throw new NotImplementedException();
        }
        public void GetDepartmentChargeablePercentage()
        {
            throw new NotImplementedException();
        }
        public void GetSumDepartmentChargeableHours()
        {
            throw new NotImplementedException();
        }
        public void GetDepartmentProjectsFee()
        {
            throw new NotImplementedException();
        }
        public void GetDepartmentProjectsNetRate()
        {
            throw new NotImplementedException();
        }
        public void GetDepartmentProjectsNetAmount()
        {
            throw new NotImplementedException();
        }
        public void GetCompanyChargeablePercentage()
        {
            throw new NotImplementedException();
        }
        public void GetSumCompanyChargeableHours()
        {
            throw new NotImplementedException();
        }
        public void GetCompanyProjectsFee()
        {
            throw new NotImplementedException();
        }
        public void GetCompanyProjectsNetAmount()
        {
            throw new NotImplementedException();
        }
        public void GetCompanyProjectsNetRate()
        {
            throw new NotImplementedException();
        }
        public void GetSumHourlyRateProjectsChargeableHours()
        {
            throw new NotImplementedException();
        }
        public void GetHourlyRateProjectsFee()
        {
            throw new NotImplementedException();
        }
        public void GetHourlyRateProjectsFeeRate()
        {
            throw new NotImplementedException();
        }
    }
}
