using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace HighwireAPIWrapper.Requests.BaseTypes
{
    public class HighwireAuthRequest : HighwireRequest
    {
        private string AppID { get; set; }
        private string SecretKey { get; set; }
        private string Token { get; set; }

        internal HighwireAuthRequest(string appID, string secretKey, string token)
            : base(eHttpMethod.Post, "auth")
        {
            this.AppID = appID;
            this.SecretKey = secretKey;
            this.Token = token;
        }

        public override HttpWebResponse ExecuteRequest()
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(HighwireAPI.BaseURL + this.APIURLSuffix);
            request.Headers.Add("x-hw-appid", this.AppID);
            request.Headers.Add("x-hw-privatekey", this.SecretKey);
            request.Headers.Add("x-hw-token", this.Token);
            request.Timeout = HighwireAPI.CallTimeout;
            request.Proxy = null;
            request.KeepAlive = false;
            request.Method = this.HttpMethod.ToString().ToUpper();
            request.ContentLength = 0; 

            if (HighwireAPI.DebugMode)
            {
                this.RequestURL = HighwireAPI.BaseURL + this.APIURLSuffix;
            }

            return GetResponse(request);
        }
    }
}
