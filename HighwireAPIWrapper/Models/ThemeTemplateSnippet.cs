using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighwireAPIWrapper.Models
{
    public class ThemeTemplateSnippet
    {
        public int? ID { get; set; }

        /// <summary>
        /// see eThemeTemplateName
        /// </summary>
        public string Name { get; set; }

        public string Template { get; set; }
    }
}
