using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Serialization;

namespace HighwireAPIWrapper.Requests.BaseTypes
{
    internal class LowerCasePropertyNamesContractResolver : DefaultContractResolver
    {
        public LowerCasePropertyNamesContractResolver()
            : base(true)
        {
        }

        protected override string ResolvePropertyName(string propertyName)
        {
            // lower case the first letter of the passed in name
            return propertyName.ToLower();
        }
    }
}
