using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class DeleteTemplateRequest : HighwireRequest
    {
        public DeleteTemplateRequest(int storeID, int templateID)
            : base(storeID, eHttpMethod.Delete, string.Format("ebay/templates/{0}.json", templateID))
        {
        }

        public DeleteTemplateRequest(int templateID)
            : base(eHttpMethod.Delete, string.Format("ebay/templates/{0}.json", templateID))
        {
        }
    }
}
