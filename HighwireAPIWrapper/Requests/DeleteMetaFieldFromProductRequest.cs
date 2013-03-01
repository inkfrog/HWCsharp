using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighwireAPIWrapper.Requests.BaseTypes;

namespace HighwireAPIWrapper.Requests
{
    public class DeleteMetaFieldFromProductRequest : HighwireRequest
    {
        public DeleteMetaFieldFromProductRequest(int storeID, int productID, int metaFieldID)
            : base(storeID, eHttpMethod.Delete, string.Format("products/{0}/metafields/{1}.json", productID, metaFieldID))
        {
        }

        public DeleteMetaFieldFromProductRequest(int productID, int metaFieldID)
            : base(eHttpMethod.Delete, string.Format("products/{0}/metafields/{1}.json", productID, metaFieldID))
        {
        }
    }
}
