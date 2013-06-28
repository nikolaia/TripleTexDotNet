using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripleTexDotNet.Services
{
    public class SyncService
    {
        private readonly JsonService _service;
        public int CustomerId { get; set; }
        public int UserId { get; set; }

        public SyncService(int syncSystem, string syncPassword, string username, string password)
        {
            _service = new JsonService("https://tripletex.no/JSON-RPC");
            Login(syncSystem, syncPassword, username, password);
        }

        public JsonService GetService()
        {
            return _service;
        }

        public void CreateTripleTextAccount()
        {
            throw new NotImplementedException();
        }

        protected void Login(int syncSystem, string syncPassword, string username, string password)
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
