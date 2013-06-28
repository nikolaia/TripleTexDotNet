using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TripleTexDotNet.Interfaces;

namespace TripleTexDotNet.Services
{
    public class HourService : IHourService
    {
        private readonly IJsonService _service;

        public HourService(IJsonService service)
        {
            _service = service;
        }

        public void HourSave()
        {
            throw new NotImplementedException();
        }

        public void HourGetTimesheet()
        {
            throw new NotImplementedException();
        }
        public void HourRemoveFromTimesheet()
        {
            throw new NotImplementedException();
        }
    }
}
