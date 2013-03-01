using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;
using HighwireAPIWrapper.Models;

namespace HighwireAPIWrapper.Requests
{
    public class CreateTemplateRequest : HighwirePostOrPutRequest<ListingTemplate>
    {
        public CreateTemplateRequest(int storeID, ListingTemplate templateData)
            : base(storeID, templateData, eHttpMethod.Post, "ebay/templates.json")
        {
        }

        public CreateTemplateRequest(ListingTemplate templateData)
            : base(templateData, eHttpMethod.Post, "ebay/templates.json")
        {
        }
    }
}
