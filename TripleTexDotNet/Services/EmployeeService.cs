using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TripleTexDotNet.Interfaces;

namespace TripleTexDotNet.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IJsonService _service;

        public EmployeeService(IJsonService service)
        {
            _service = service;
        }

        public void EmployeeGetLoginEmployeeUsers()
        {
            throw new NotImplementedException();
        }

        public void GetCurrentUsers()
        {
            throw new NotImplementedException();
        }
    }
}
