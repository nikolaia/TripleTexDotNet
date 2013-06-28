using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripleTexDotNet.Interfaces
{
    public interface ISyncService
    {
        void CreateTripleTextAccount();
        void Login(int syncSystem, string syncPassword, string username, string password);
        bool SwitchCompany(int companyId);
        void Logout();
    }
}
