using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Models;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class EditThemeTemplateRequest : HighwirePostOrPutRequest<ThemeTemplate>
    {
        public EditThemeTemplateRequest(int storeID, eThemeTemplateName templateName, ThemeTemplate templateData)
            : base(storeID, templateData, eHttpMethod.Put, string.Format("theme/{0}.json", Enum.GetName(typeof(eThemeTemplateName), templateName).ToLower()))
        {
        }

        public EditThemeTemplateRequest(eThemeTemplateName templateName, ThemeTemplate templateData)
            : base(templateData, eHttpMethod.Put, string.Format("theme/{0}.json", Enum.GetName(typeof(eThemeTemplateName), templateName).ToLower()))
        {
        }
    }
}
