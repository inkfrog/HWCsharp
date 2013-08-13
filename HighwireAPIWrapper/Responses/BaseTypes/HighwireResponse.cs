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
        public DebugData DebugInfo { get; set; }

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

            if (response != null && HighwireAPI.DebugMode)
            {
                using (NoCloseStreamReader reader = new NoCloseStreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    this.DebugInfo.ResponseData = reader.ReadToEnd();
                }
            }
        }
    }

    public class HighwireResponse<ResponseType> : HighwireResponse
    {
        public ResponseType Data { get; internal set; }

        public override void Initialize(HttpWebResponse response)
        {
            MemoryStream responseStr = new MemoryStream();
            if (response != null)
            {
                response.GetResponseStream().CopyTo(responseStr);
                responseStr.Position = 0;

                if (HighwireAPI.DebugMode)
                {
                    using (NoCloseStreamReader reader = new NoCloseStreamReader(responseStr, Encoding.UTF8))
                    {
                        this.DebugInfo.ResponseData = reader.ReadToEnd();
                    }

                    responseStr.Position = 0;
                }
            }

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

                using (StreamReader reader = new StreamReader(responseStr, Encoding.UTF8))
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

    /// <summary>
    /// Encapsulates a stream reader which does not close the underlying stream.
    /// </summary>
    internal class NoCloseStreamReader : StreamReader
    {
        /// <summary>
        /// Creates a new stream reader object.
        /// </summary>
        /// <param name="stream">The underlying stream to read from.</param>
        /// <param name="encoding">The encoding for the stream.</param>
        public NoCloseStreamReader(Stream stream, Encoding encoding)
            : base(stream, encoding)
        {
        }

        /// <summary>
        /// Disposes of the stream writer.
        /// </summary>
        /// <param name="disposing">True to dispose managed objects.</param>
        protected override void Dispose(bool disposeManaged)
        {
            // Dispose the stream writer but pass false to the dispose
            // method to stop it from closing the underlying stream
            base.Dispose(false);
        }
    }
}
