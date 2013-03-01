using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class AuthRequest : HighwireAuthRequest
    {
        public AuthRequest(string appID, string secretKey, string token) : base(appID, secretKey, token)
        {
        }
    }
}
