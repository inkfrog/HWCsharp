﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace HighwireAPIWrapper.Requests.BaseTypes
{
    public class HighwirePostOrPutRequest<PostDataType> : HighwireRequest
    {
        private PostDataType PostData { get; set; }

        internal HighwirePostOrPutRequest(int storeID, PostDataType postData, eHttpMethod httpMethod, string apiURLSuffix)
            : base(storeID,httpMethod,apiURLSuffix)
        {
            this.PostData = postData;
        }

        internal HighwirePostOrPutRequest(PostDataType postData, eHttpMethod httpMethod, string apiURLSuffix)
            : base(httpMethod, apiURLSuffix)
        {
            this.PostData = postData;
        }

        public override HttpWebResponse ExecuteRequest()
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(HighwireAPI.BaseURL + this.APIURLSuffix);
            if (HighwireAPI.IsMasterKey)
            {
                request.Headers.Add("x-hw-masterkey", HighwireAPI.APIKey);
                request.Headers.Add("x-hw-storeid", this.StoreID.ToString());
            }
            string svcCredentials = Convert.ToBase64String(ASCIIEncoding.UTF8.GetBytes(HighwireAPI.APIKey + ":"));
            request.Headers.Add("Authorization", "Basic " + svcCredentials);
            request.Proxy = null;
            request.KeepAlive = false;
            request.Timeout = HighwireAPI.CallTimeout;
            request.Method = this.HttpMethod.ToString().ToUpper();

            if (HighwireAPI.DebugMode)
            {
                this.RequestURL = HighwireAPI.BaseURL + this.APIURLSuffix;
            }

            if (this.PostData != null && (this.HttpMethod == eHttpMethod.Post || this.HttpMethod == eHttpMethod.Put))
            {
                request.ContentType = "application/json; charset=UTF-8";

                StringBuilder json = new StringBuilder();
                using (StringWriter writer = new StringWriter(json))
                {
                    JsonSerializer serializer = new JsonSerializer()
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        MissingMemberHandling = MissingMemberHandling.Ignore,
#if DEBUG
                        Formatting = Formatting.Indented,
#else
                        Formatting = Formatting.None,
#endif
                        DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                        ContractResolver = new LowerCasePropertyNamesContractResolver()
                    };
                    serializer.Converters.Add(new IsoDateTimeConverter());
                    serializer.Serialize(writer, this.PostData);
                }

                if (HighwireAPI.DebugMode)
                {
                    this.RequestData = json.ToString();
                }

                byte[] requestData = Encoding.UTF8.GetBytes(json.ToString());
                request.GetRequestStream().Write(requestData, 0, requestData.Length);
                request.GetRequestStream().Close();
            }
            else
            {
                request.ContentType = "application/x-www-form-urlencoded";
            }

            return GetResponse(request);
        }
    }
}
