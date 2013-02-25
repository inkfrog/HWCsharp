using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace HighwireAPIWrapper.Responses.BaseTypes
{
    public class HighwireResponse : IHighwireResponse
    {
        public Exception Error { get; set; }

        public HttpStatusCode StatusCode { get; internal set; }
        public string StatusDescription
        {
            get
            {
                switch (this.StatusCode)
                {
                    case HttpStatusCode.OK:
                        return "The request completed and a response body is provided.";
                    case HttpStatusCode.NoContent:
                        return "The request completed and the response body is empty.";
                    case HttpStatusCode.NotFound:
                        return "The requested resource doesn't exist.";
                    case HttpStatusCode.Forbidden:
                        return "Invalid API credentials were supplied.";
                    case HttpStatusCode.MethodNotAllowed:
                        return "The request method is not available on the API endpoint.";
                    case HttpStatusCode.InternalServerError:
                        return "Something didn't go right on Highwire's end.";
                    default:
                        return "Unknown status code: " + this.StatusCode.ToString();
                }
            }
        }


        public virtual void Initialize(HttpWebResponse response)
        {
            this.StatusCode = response == null ? HttpStatusCode.Gone : response.StatusCode;

            /*using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.ASCII))
            {
                string txt = reader.ReadToEnd();
            }*/
        }
    }

    public class HighwireResponse<ResponseType> : HighwireResponse
    {
        public ResponseType Data { get; internal set; }

        public override void Initialize(HttpWebResponse response)
        {
            /*if (typeof(ResponseType) == typeof(HighwireAPIWrapper.Models.ListingProfile))
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.ASCII))
                {
                    string txt = reader.ReadToEnd();
                }
            }*/

            this.StatusCode = response == null ? HttpStatusCode.Gone : response.StatusCode;

            if (this.StatusCode == HttpStatusCode.OK)
            {
                JsonSerializer deserizalier = new JsonSerializer()
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore,
#if DEBUG
                    Formatting = Formatting.Indented,
#else
                        Formatting = Formatting.None,
#endif
                    DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                    DateParseHandling = DateParseHandling.DateTime
                };

                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.ASCII))
                {
                    JsonTextReader json = new JsonTextReader(reader);
                    this.Data = deserizalier.Deserialize<ResponseType>(json);
                }
            }
        }

        protected HighwireResponse()
        {
        }
    }
}
