using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripleTexDotNet.Services
{
    public class VoucherService
    {
        private readonly SyncService _syncService;

        public VoucherService(SyncService syncService)
        {
            _syncService = syncService;
        }

        public void VoucherImportMamutGBAT10()
        {
            throw new NotImplementedException();
        }
    }
}
