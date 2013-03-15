using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighwireAPIWrapper.Responses.BaseTypes
{
    public class DebugData
    {
        public string RequestURL { get; set; }
        public string RequestData { get; set; }
        public string ResponseData { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("RequestURL: ");
            sb.AppendLine(this.RequestURL);
            sb.AppendLine();
            sb.Append("RequestData: ");
            sb.AppendLine(string.IsNullOrWhiteSpace(this.RequestData) ? "N/A" : this.RequestData);
            sb.AppendLine();
            sb.Append("ResponseData: ");
            sb.AppendLine(string.IsNullOrWhiteSpace(this.ResponseData) ? "N/A" : this.ResponseData);
            return sb.ToString();
        }
    }
}
