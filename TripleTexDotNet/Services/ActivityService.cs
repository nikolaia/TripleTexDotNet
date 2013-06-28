using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TripleTexDotNet.Interfaces;

namespace TripleTexDotNet.Services
{
    public class ActivityService : IActivityService
    {
        private readonly IJsonService _service;

        public ActivityService(IJsonService service)
        {
            _service = service;
        }

        public void GetForTimesheet()
        {
            throw new NotImplementedException();
        }
    }
}
