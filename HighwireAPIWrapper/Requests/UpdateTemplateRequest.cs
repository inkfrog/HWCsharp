using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Models;

namespace HighwireAPIWrapper.Requests
{
    public class UpdateTemplateRequest : HighwirePostOrPutRequest<ListingTemplate>
    {
        public UpdateTemplateRequest(int storeID, ListingTemplate templateData)
            : base(storeID, templateData, eHttpMethod.Put, string.Format("ebay/templates/{0}.json", templateData.ID.Value))
        {
        }

        public UpdateTemplateRequest(ListingTemplate templateData)
            : base(templateData, eHttpMethod.Put, string.Format("ebay/templates/{0}.json", templateData.ID.Value))
        {
        }
    }
}
