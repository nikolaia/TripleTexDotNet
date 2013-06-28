using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripleTexDotNet
{
    public interface IJsonService
    {
        T Call<T>(string method, params object[] params_) where T : class;
    }
}
