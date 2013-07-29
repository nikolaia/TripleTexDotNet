using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripleTexDotNet.Interfaces
{
    public interface ITripleTexFacade
    {
        ICompanyService GetCompanyService();
        IOrderService GetOrderService();
        void Dispose();
    }
}
