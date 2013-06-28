using System;
using TripleTexDotNet.Interfaces;

namespace TripleTexDotNet.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IJsonService _service;

        public ProjectService(IJsonService service)
        {
            _service = service;
        }

        public void GetForTimesheet()
        {
            throw new NotImplementedException();
        }
    }
}
