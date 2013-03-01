using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Models;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class EditThemeTemplateSnippetRequest : HighwirePostOrPutRequest<ThemeTemplateSnippet>
    {
        public EditThemeTemplateSnippetRequest(int storeID, ThemeTemplateSnippet snippetData)
            : base(storeID, snippetData, eHttpMethod.Put, string.Format("snippets/{0}.json", snippetData.ID.Value))
        {
        }

        public EditThemeTemplateSnippetRequest(ThemeTemplateSnippet snippetData)
            : base(snippetData, eHttpMethod.Put, string.Format("snippets/{0}.json", snippetData.ID.Value))
        {
        }
    }
}
