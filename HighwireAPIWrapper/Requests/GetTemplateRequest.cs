using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetTemplateRequest : HighwireGetRequest<GetTemplateRequest>
    {
        public GetTemplateRequest(int storeID, int templateID)
            : base(storeID, string.Format("ebay/templates/{0}.json", templateID))
        {
        }

        public GetTemplateRequest(int templateID)
            : base(string.Format("ebay/templates/{0}.json", templateID))
        {
        }
    }
}
