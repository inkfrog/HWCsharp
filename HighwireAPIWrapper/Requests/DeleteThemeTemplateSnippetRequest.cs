using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class DeleteThemeTemplateSnippetRequest : HighwireRequest
    {
        public DeleteThemeTemplateSnippetRequest(int storeID, int snippetID)
            : base(storeID, eHttpMethod.Delete, string.Format("theme/snippets/{0}.json", snippetID))
        {
        }
    }
}
