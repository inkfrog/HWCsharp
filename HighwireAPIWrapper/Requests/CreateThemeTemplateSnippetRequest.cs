using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Models;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class CreateThemeTemplateSnippetRequest : HighwirePostOrPutRequest<ThemeTemplateSnippet>
    {
        public CreateThemeTemplateSnippetRequest(int storeID, ThemeTemplateSnippet snippetData)
            : base(storeID, snippetData, eHttpMethod.Post, "theme/snippets.json")
        {
        }

        public CreateThemeTemplateSnippetRequest(ThemeTemplateSnippet snippetData)
            : base(snippetData, eHttpMethod.Post, "theme/snippets.json")
        {
        }
    }
}
