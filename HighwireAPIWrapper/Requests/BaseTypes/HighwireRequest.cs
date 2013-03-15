using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Configuration;
using System.Reflection;
using System.Web;
using Newtonsoft.Json.Serialization;

namespace HighwireAPIWrapper.Requests.BaseTypes
{
    public abstract class HighwireRequest
    {
        protected int StoreID { get; private set; }
        protected string APIURLSuffix { get; private set; }
        protected eHttpMethod HttpMethod { get; private set; }
        internal Exception Error { get; set; }
        internal string RequestData { get; set; }
        internal string RequestURL { get; set; }

        internal HighwireRequest(int storeID, eHttpMethod httpMethod, string apiURLSuffix)
        {
            this.StoreID = storeID;
            this.HttpMethod = httpMethod;
            this.APIURLSuffix = apiURLSuffix;
        }

        internal HighwireRequest(eHttpMethod httpMethod, string apiURLSuffix)
        {
            this.HttpMethod = httpMethod;
            this.APIURLSuffix = apiURLSuffix;
        }

        public virtual HttpWebResponse ExecuteRequest()
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(HighwireAPI.BaseURL + this.APIURLSuffix);
            if (HighwireAPI.IsMasterKey)
            {
                request.Headers.Add("x-hw-masterkey", HighwireAPI.APIKey);
                request.Headers.Add("x-hw-storeid", this.StoreID.ToString());
            }
            if (HighwireAPI.DebugMode)
            {
                this.RequestURL = HighwireAPI.BaseURL + this.APIURLSuffix;
            }
            request.Credentials = new NetworkCredential() { UserName = HighwireAPI.APIKey };
            request.Timeout = HighwireAPI.CallTimeout;
            request.Proxy = null;
            request.KeepAlive = false;
            request.Method = this.HttpMethod.ToString().ToUpper();
         
            return GetResponse(request);
        }

        protected HttpWebResponse GetResponse(HttpWebRequest request)
        {

            //TODO: should implement retrying on certain status codes (e.g. timeout)
            try
            {
                return (HttpWebResponse)request.GetResponse();
            }
            catch (WebException e)
            {
                this.Error = new ApplicationException("Exception calling url: " + request.RequestUri.ToString(), e);

                //return response regardless of exception so calling code can check the status code
                return (HttpWebResponse)e.Response;
            }
        }
    }
}
