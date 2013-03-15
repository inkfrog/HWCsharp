using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace HighwireAPIWrapper.Responses.BaseTypes
{
    public interface IHighwireResponse
    {
        void Initialize(HttpWebResponse response);
        Exception Error { get; set; }
        DebugData DebugInfo { get; set; }
    }
}
