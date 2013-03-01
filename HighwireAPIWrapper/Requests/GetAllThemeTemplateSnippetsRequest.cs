using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetAllThemeTemplateSnippetsRequest : HighwireGetRequest<GetAllThemeTemplateSnippetsRequest>
    {
        public GetAllThemeTemplateSnippetsRequest(int storeID)
            : base(storeID, "theme/snippets.json")
        {
        }

        public GetAllThemeTemplateSnippetsRequest()
            : base("theme/snippets.json")
        {
        }
    }
}
