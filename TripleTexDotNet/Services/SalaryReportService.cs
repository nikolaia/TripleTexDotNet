using System;
using TripleTexDotNet.Interfaces;

namespace TripleTexDotNet.Services
{
    public class SalaryReportService : ISalaryReportService
    {
        private readonly IJsonService _service;

        public SalaryReportService(IJsonService service)
        {
            _service = service;
        }

        public void GetEmployeeVacationBalance()
        {
            throw new NotImplementedException();
        }
    }
}
