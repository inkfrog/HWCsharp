using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Responses;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Responses.BaseTypes;
using System.Net;
using HighwireAPIWrapper.Requests;

namespace HighwireAPIWrapper
{
    public class HighwireAPI
    {
        private static readonly int DefaultTimeout = 10000;
        private static string m_BaseURL = null;

        /// <summary>
        /// Base component of the URL with which to access the Highwire API over HTTP. Must begin with 'http' and end with '/'. Default https://app.highwire.com/api/
        /// </summary>
        public static string BaseURL
        {
            internal get
            {
                return m_BaseURL;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.ToLower().StartsWith("http") || !value.ToLower().EndsWith("/"))
                {
                    throw new ArgumentException("Invalid Highwire API BaseURL. Must begin with HTTP and end with /");
                }

                m_BaseURL = value;
            }
        }

        public static string APIKey { internal get; set; }

        /// <summary>
        /// For internal Highwire use only.
        /// </summary>
        public static bool IsMasterKey { internal get; set; }

        /// <summary>
        /// Number of millseconds before an http request to the API is terminated. Default 10000.
        /// </summary>
        public static int CallTimeout { internal get; set; }

        public static bool DebugMode { internal get; set; }

        public static ResponseType DoRequest<RequestType, ResponseType>(RequestType request) where RequestType : HighwireRequest  
                                                                               where ResponseType : IHighwireResponse, new()

        {
            if (!typeof(AuthRequest).Equals(typeof(RequestType)) && string.IsNullOrWhiteSpace(APIKey))
            {
                throw new InvalidOperationException("APIKey required for making Highwire API calls.");
            }

            var response = new ResponseType();
            if (DebugMode)
            {
                response.DebugInfo = new DebugData();
            }

            HttpWebResponse webResponse = request.ExecuteRequest();
            response.Initialize(webResponse);
            if (webResponse != null)
            {
                webResponse.Close();
            }
            response.Error = request.Error;

            if (DebugMode)
            {
                response.DebugInfo.RequestURL = request.RequestURL;
                response.DebugInfo.RequestData = request.RequestData;
            }

            return response;
        }

        static HighwireAPI()
        {
            m_BaseURL = "https://app.highwire.com/api/";
            CallTimeout = DefaultTimeout;
        }
    }
}
