using System;
using TripleTexDotNet.Interfaces;

namespace TripleTexDotNet.Services
{
    public class VoucherService : IVoucherService
    {
        private readonly IJsonService _service;

        public VoucherService(IJsonService service)
        {
            _service = service;
        }

        public void ImportMamutGbat10()
        {
            throw new NotImplementedException();
        }
    }
}
