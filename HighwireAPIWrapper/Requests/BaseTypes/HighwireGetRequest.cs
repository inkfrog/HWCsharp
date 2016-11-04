using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Configuration;
using System.Web;

namespace HighwireAPIWrapper.Requests.BaseTypes
{
    public class HighwireGetRequest<RequestType> : HighwireRequest
    {
        internal HighwireGetRequest(int storeID, string apiURLSuffix)
            : base(storeID, eHttpMethod.Get, apiURLSuffix)
        {
        }

        internal HighwireGetRequest(string apiURLSuffix)
            : base(eHttpMethod.Get, apiURLSuffix)
        {
        }

        public override HttpWebResponse ExecuteRequest()
        {
            StringBuilder url = new StringBuilder(HighwireAPI.BaseURL);
            url.Append(this.APIURLSuffix);
            url.Append("?");
            var fields = typeof(RequestType).GetFields();
            foreach (var field in fields)
            {
                var value = field.GetValue(this);

                if (value != null)
                {
                    url.Append(field.Name.ToLower());
                    url.Append("=");
                    url.Append(HttpUtility.UrlEncode(value.ToString()));
                    url.Append("&");
                }
            }

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url.ToString());
            if (HighwireAPI.IsMasterKey)
            {
                request.Headers.Add("x-hw-masterkey", HighwireAPI.APIKey);
                request.Headers.Add("x-hw-storeid", this.StoreID.ToString());
            }
            if (HighwireAPI.DebugMode)
            {
                this.RequestURL = url.ToString();
            }

            string svcCredentials = Convert.ToBase64String(ASCIIEncoding.UTF8.GetBytes(HighwireAPI.APIKey + ":"));
            request.Headers.Add("Authorization", "Basic " + svcCredentials);

            request.Timeout = HighwireAPI.CallTimeout;
            request.Proxy = null;
            request.KeepAlive = false;
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";

            return GetResponse(request);
        }
    }
}
