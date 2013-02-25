using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetAllTemplatesRequest : HighwireGetRequest<GetAllTemplatesRequest>
    {
        public GetAllTemplatesRequest(int storeID)
            : base(storeID, "ebay/templates.json")
        {
        }
    }
}
