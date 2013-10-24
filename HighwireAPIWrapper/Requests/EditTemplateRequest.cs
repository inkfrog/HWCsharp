using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Models;

namespace HighwireAPIWrapper.Requests
{
    public class EditTemplateRequest : HighwirePostOrPutRequest<ListingTemplate>
    {
        public EditTemplateRequest(int storeID, ListingTemplate templateData)
            : base(storeID, templateData, eHttpMethod.Put, string.Format("ebay/templates/{0}.json", templateData.ID.Value))
        {
        }

        public EditTemplateRequest(ListingTemplate templateData)
            : base(templateData, eHttpMethod.Put, string.Format("ebay/templates/{0}.json", templateData.ID.Value))
        {
        }
    }
}
