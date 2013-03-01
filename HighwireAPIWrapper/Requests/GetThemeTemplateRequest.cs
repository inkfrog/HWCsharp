using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class GetThemeTemplateRequest : HighwireGetRequest<GetThemeTemplateRequest>
    {
        public GetThemeTemplateRequest(int storeID, eThemeTemplateName templateName) : base(storeID,
            string.Format("theme/{0}.json", Enum.GetName(typeof(eThemeTemplateName), templateName).ToLower()))
        {
        }

        public GetThemeTemplateRequest(eThemeTemplateName templateName)
            : base(string.Format("theme/{0}.json", Enum.GetName(typeof(eThemeTemplateName), templateName).ToLower()))
        {
        }
    }
}
