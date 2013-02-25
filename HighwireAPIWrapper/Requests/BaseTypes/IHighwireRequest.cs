using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace HighwireAPIWrapper.Requests.BaseTypes
{
    public interface IHighwireRequest
    {
        HttpWebResponse ExecuteRequest();
        Exception GetException();
    }
}
