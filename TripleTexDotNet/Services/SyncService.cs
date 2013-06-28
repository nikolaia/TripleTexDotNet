using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TripleTexDotNet.Interfaces;

namespace TripleTexDotNet.Services
{
    public class SyncService : ISyncService
    {
        private readonly IJsonService _service;
        public int CustomerId { get; set; }
        public int UserId { get; set; }

        public SyncService(IJsonService service)
        {
            _service = service;
        }

        public void CreateTripleTextAccount()
        {
            throw new NotImplementedException();
        }

        public void Login(int syncSystem, string syncPassword, string username, string password)
        {
            var res = _service.Call<string[]>("Sync.login", syncSystem, syncPassword, username, password);

            CustomerId = Convert.ToInt32(res[0]);
            UserId = Convert.ToInt32(res[1]);
        }

        public bool SwitchCompany(int companyId)
        {
            var res = _service.Call<string[]>("Sync.switchCompany");

            CustomerId = Convert.ToInt32(res[0]);
            UserId = Convert.ToInt32(res[1]);

            return true;
        }

        public void Logout()
        {
            _service.Call<object>("Sync.logout");
        }
    }
}
