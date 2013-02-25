using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetThemeTemplateSnippetRequest : HighwireGetRequest<GetThemeTemplateSnippetRequest>
    {
        public GetThemeTemplateSnippetRequest(int storeID, int snippetID)
            : base(storeID, string.Format("theme/snippets/{0}.json", snippetID))
        {
        }
    }

}
